using Momofy.NET.Models.Requests;
using Momofy.NET.Models.Responses;

namespace Momofy.NET;
public interface IMomofyClient
{
    Task<RequestPaymentResponse> RequestPayment(RequestPaymentRequest request);
    Task<VerifyTransactionResponse> VerifyTransaction(string transactionReference);
    Task<TransactionsResponse> ListTransactions(int page = 1, int size = 10);
}
