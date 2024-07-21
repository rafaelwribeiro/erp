namespace erp.domain.Entities;
public enum TransactionType
{
    Sale,
    Expense
}
public class CashTransaction : Entity
{
    public int CashRegisterId { get; set; }
    public CashRegister CashRegister { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
}
