namespace Momofy.NET.Models.Responses;
public class RequestPaymentResponse : BaseResponse
{
    public RequestPaymentResult Result { get; set; }
    public Meta Meta { get; set; }
}
