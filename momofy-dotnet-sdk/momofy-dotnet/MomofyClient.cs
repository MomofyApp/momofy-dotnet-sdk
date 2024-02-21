using Microsoft.Extensions.Configuration;
using Momofy.NET.Helpers;
using Momofy.NET.Models.Requests;
using Momofy.NET.Models.Responses;
using Newtonsoft.Json;

namespace Momofy.NET;
/// <summary>
/// A .NET client for interacting with the Momofy API
/// </summary>
public class MomofyClient : IMomofyClient
{
    private static readonly string BASE_URL = "https://api.momofy.com";
    private static readonly string REQUEST_PAYMENT_URL = "/transactions/request";
    private static readonly string VERIFY_TRANSACTION_URL = "/transactions/verify";
    private static readonly string LIST_TRANSACTIONS_URL = "/transactions";


    private readonly MomofyConfiguration? momofyConfiguration;
    private readonly HttpClient _httpClient;
    private readonly string secretKey;

    private bool isSecretKeySet => !string.IsNullOrEmpty(momofyConfiguration?.SecretKey);

    public MomofyClient(string secretKey)
    {
        this.secretKey = secretKey;
    }
    public MomofyClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {

        momofyConfiguration = configuration.GetSection("Momofy").Get<MomofyConfiguration>()!;

        _httpClient = httpClientFactory.CreateClient();

        if (!isSecretKeySet)
        {
            throw new Exception("Secret key is not set");
        }

        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {momofyConfiguration?.SecretKey}");
    }

    /// <summary>
    /// Returns a list of transactions
    /// </summary>
    /// <param name="page"></param>
    /// <param name="size"></param>
    /// <returns></returns>
    public async Task<TransactionsResponse> ListTransactions(int page = 0, int size = 10)
    {
        var response = await BaseHttpClient.GetAsync($"{BASE_URL}{LIST_TRANSACTIONS_URL}?page={page}&size={size}", secretKey);
        return JsonConvert.DeserializeObject<TransactionsResponse>(response)!;
    }

    /// <summary>
    /// Creates a payment request
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<RequestPaymentResponse> RequestPayment(RequestPaymentRequest request)
    {
        var content = await BaseHttpClient.PostAsync($"{BASE_URL}{REQUEST_PAYMENT_URL}", JsonConvert.SerializeObject(request), secretKey);
        return JsonConvert.DeserializeObject<RequestPaymentResponse>(content)!;
    }

    /// <summary>
    /// Verifies a transaction
    /// </summary>
    /// <param name="transactionReference"></param>
    /// <returns></returns>
    public async Task<VerifyTransactionResponse> VerifyTransaction(string transactionReference)
    {
        var response = await BaseHttpClient.GetAsync($"{BASE_URL}{VERIFY_TRANSACTION_URL}/transaction_ref={transactionReference}", secretKey);
        return JsonConvert.DeserializeObject<VerifyTransactionResponse>(response)!;
    }
}
