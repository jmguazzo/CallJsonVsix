using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace CallJson
{
    static class JsonControler
    {
        static class Methods
        {
            internal static HttpResponseMessage Post(HttpClient client, string uri, string body)
            {
                return client.PostAsync(uri, new StringContent(
                         JsonConvert.SerializeObject(body).ToString(),
                         Encoding.UTF8, "application/json")).Result;
            }

            internal static HttpResponseMessage Put(HttpClient client, string uri, string body)
            {
                return client.PutAsync(uri, new StringContent(
                         JsonConvert.SerializeObject(body).ToString(),
                         Encoding.UTF8, "application/json")).Result;
            }

            internal static HttpResponseMessage Delete(HttpClient client, string uri, string body)
            {
                return client.DeleteAsync(uri).Result;
            }

            internal static HttpResponseMessage Get(HttpClient client, string uri, string body)
            {
                return client.GetAsync(uri).Result;
            }
        }

        static JsonControler()
        {

        }
        public static string GET(string uri, Dictionary<string, string> headers)
        {

            return ExecuteRequest(uri, headers, string.Empty, Methods.Get);
        }


        public static string POST(string uri, Dictionary<string, string> headers, string body)
        {
            return ExecuteRequest(uri, headers, body, Methods.Post);
        }

        public static string PUT(string uri, Dictionary<string, string> headers, string body)
        {
            return ExecuteRequest(uri, headers, body, Methods.Put);
        }



        public static string DELETE(string uri, Dictionary<string, string> headers)
        {
            return ExecuteRequest(uri, headers, string.Empty, Methods.Delete);
        }
        private static string ExecuteRequest(string uri,
            Dictionary<string, string> headers,
            string body,
            Func<HttpClient, string, string, HttpResponseMessage> executionMethod)
        {
            string result;
            using (var client = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true }))
            {
                InitClient(client, headers);

                result = GetResultFrom(executionMethod(client, uri, body));

            }
            return result;
        }



        private static string GetResultFrom(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return ConvertToJson(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return "Error : " + ((int)response.StatusCode).ToString() + Environment.NewLine +
                    response.ReasonPhrase + Environment.NewLine +
                    response.Content.ReadAsStringAsync().Result;
            }

        }



        private static void InitClient(HttpClient client, Dictionary<string, string> headers)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            foreach (var key in headers.Keys)
            {
                client.DefaultRequestHeaders.Add(key, headers[key]);
            }

        }

        private static string ConvertToJson(string jsonString)
        {
            string converted = jsonString;
            try
            {
                dynamic parsedJson = JsonConvert.DeserializeObject(jsonString);
                converted = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);

            }
            catch (Exception ex)
            {
                converted = "JSON Error : " + ex.Message + Environment.NewLine +
                    "Returned value : " + Environment.NewLine + converted;
            }

            return converted;
        }
    }
}
