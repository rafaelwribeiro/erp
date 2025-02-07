using erp.domain.Enumerators;

namespace erp.domain.Entities;

public enum PaymentStatus
{
    Pending,    // Aguardando pagamento
    Paid,       // Pago
    Failed,     // Falha no pagamento
    Cancelled,  // Cancelado pelo usuário ou sistema
    Refunded    // Reembolsado
}

public class OrderPayment : Entity
{
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
    public decimal Amount { get; set; } // Valor pago
    public decimal ReceivedAmount { get; set; }
    public DateTime? PaidAt { get; set; } // Data do pagamento efetivo

    public void UpdatePaymentStatus(PaymentStatus newStatus)
    {
        if (newStatus == PaymentStatus.Paid && this.Status != PaymentStatus.Pending)
            throw new InvalidOperationException("O pagamento só pode ser marcado como pago se estiver pendente.");

        if (newStatus == PaymentStatus.Refunded && this.Status != PaymentStatus.Paid)
            throw new InvalidOperationException("Só é possível reembolsar pagamentos que foram pagos.");

        this.Status = newStatus;

        if (newStatus == PaymentStatus.Paid)
            this.PaidAt = DateTime.UtcNow;
    }

    public decimal GetChange()
    {
        if (PaymentMethod.Type != PaymentMethodType.Cash)
            return 0;

        return Math.Max(0, ReceivedAmount - Amount);
    }
}
