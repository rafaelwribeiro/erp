namespace erp.domain.Entities;

public class Terminal
{
    public int TerminalId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;

    // Cada terminal pode ter múltiplos registros de caixa
    public List<CashRegister> CashRegisters { get; set; } = new List<CashRegister>();
}
