using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Momofy.NET.Helpers;
public static class HttpConnection
{
    public static HttpClient CreateClient(string secretKey)
    {
        var client = new HttpClient()
        {
            BaseAddress = new Uri("https://api.momofy.com")
        };
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", secretKey);
        return client;
    }
    
}
