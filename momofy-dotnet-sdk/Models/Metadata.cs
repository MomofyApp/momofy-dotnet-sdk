namespace Momofy.NET.Models;
public class Metadata
{
    public string FinancialTransactionId { get; set; }
    public string ExternalId { get; set; }
    public string Amount { get; set; }
    public string Currency { get; set; }
    public Payer Payer { get; set; }
    public string PayerMessage { get; set; }
    public string PayeeNote { get; set; }
    public string Status { get; set; }
}
