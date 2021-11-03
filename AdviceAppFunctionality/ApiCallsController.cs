using System;
using System.Collections.Generic;
using System.Net.Http;

namespace AdviceAppFunctionality
{
    public class ApiCallsController
    {
        public string HttpGetRelease(string url)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = httpClient.GetStringAsync(new Uri(url)).Result;
                    return response;
                }
                catch (AggregateException)
                {
                    return null;
                }
            }
        }
        
        public string HttpPostRequest(string url, IEnumerable<KeyValuePair<string,string>> contentValues)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new FormUrlEncodedContent(contentValues);
                try
                {
                    var result = httpClient.PostAsync(new Uri(url), content);
                    string resultContent = result.Result.Content.ReadAsStringAsync().Result;
                    return resultContent;
                }
                catch (AggregateException)
                {
                    return null;
                }
            }
        }
    }
}
