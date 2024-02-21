namespace Momofy.NET.Models.Requests;
public class RequestPaymentRequest
{
    public string Amount { get; set; }
    public string Channel { get; set; }
    public string Currency { get; set; }
    public Customer Customer { get; set; }
    public string Provider { get; set; }
    public string Reference_code { get; set; }
    public string Transaction_note { get; set; }
}
