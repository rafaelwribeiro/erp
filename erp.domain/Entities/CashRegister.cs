namespace erp.domain.Entities;

using System;
using System.Collections.Generic;

public class CashRegister : Entity
{
    public DateTime Date { get; set; }
    public int TerminalId { get; set; } // Referência ao terminal
    public Terminal Terminal { get; set; } // Navegação ao terminal
    public decimal OpeningBalance { get; set; }
    public decimal ClosingBalance { get; set; }
    public decimal TotalSales { get; set; }
    public decimal TotalExpenses { get; set; }
    public List<CashTransaction> Transactions { get; set; } = new List<CashTransaction>();

    public void AddTransaction(CashTransaction transaction)
    {
        Transactions.Add(transaction);
        if (transaction.Type == TransactionType.Sale)
        {
            TotalSales += transaction.Amount;
        }
        else if (transaction.Type == TransactionType.Expense)
        {
            TotalExpenses += transaction.Amount;
        }
    }

    public void CloseRegister()
    {
        ClosingBalance = OpeningBalance + TotalSales - TotalExpenses;
    }
}
