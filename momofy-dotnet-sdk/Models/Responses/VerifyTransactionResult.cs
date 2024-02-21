namespace Momofy.NET.Models.Responses;
public class VerifyTransactionResult
{
    public int Id { get; set; }
    public string Channel { get; set; }
    public string Message { get; set; }
    public string Currency { get; set; }
    public string Payment_phone { get; set; }
    public string Reference_code { get; set; }
    public string Gateway_status { get; set; }
    public Metadata Meta_data { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }
    public string Environment { get; set; }
    public DateTime Created_at { get; set; }
    public Meta Meta { get; set; }

}
