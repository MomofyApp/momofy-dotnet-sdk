namespace Momofy.NET.Models.Responses;
public class VerifyTransactionResponse : BaseResponse
{
    public VerifyTransactionResult Result { get; set; }
    public Meta Meta { get; set; }
}
