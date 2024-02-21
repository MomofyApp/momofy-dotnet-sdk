using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momofy.NET.Helpers;
internal class BaseHttpClient
{
    internal static async Task<string> GetAsync(string url, string secretKey)
    {
        var client = HttpConnection.CreateClient(secretKey);
        var response = await client.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }

    public static async Task<string> PostAsync(string url, string data, string secretKey)
    {
        var client = HttpConnection.CreateClient(secretKey);
        HttpResponseMessage httpResponse = await client.PostAsync(url, new StringContent(data, Encoding.UTF8, "application/json"));
        return await httpResponse.Content.ReadAsStringAsync();
    }
}
