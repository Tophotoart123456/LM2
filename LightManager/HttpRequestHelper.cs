using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Helper
{
    public static class HttpRequestHelper
    {
        /// <summary>
        /// Http Get Request
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string HttpGetRequest(string url)
        {
            string strGetResponse = string.Empty;
            try
            {
                var getRequest = CreateGetHttpWebRequest(url);
                var getResponse = getRequest.GetResponse() as HttpWebResponse;
                strGetResponse = GetHttpResponse(getResponse, "GET");
            }
            catch (Exception ex)
            {
                strGetResponse = ex.Message;
            }
            return strGetResponse;
        }

        /// <summary>
        /// Http Get Request Async
        /// </summary>
        /// <param name="url"></param>
        public static async Task<string> HttpGetRequestAsync(string url)
        {
            string strGetResponse = string.Empty;
            try
            {
                var getRequest = CreateGetHttpWebRequest(url);
                var getResponse = await getRequest.GetResponseAsync() as HttpWebResponse;
                strGetResponse = GetHttpResponse(getResponse, "GET");
            }
            catch (Exception ex)
            {
                strGetResponse = ex.Message;
            }
            return strGetResponse;
            
        }

        /// <summary>
        /// Http Post Request
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postJsonData"></param>
        /// <returns></returns>
        public static string HttpPostRequest(string url, string postJsonData)
        {
            string strPostReponse = string.Empty;
            try
            {
                var bytes = Encoding.UTF8.GetBytes(postJsonData);
                var postRequest = HttpWebRequest.Create(url) as HttpWebRequest;
                postRequest.KeepAlive = false;
                postRequest.Timeout = 2000;
                postRequest.Method = "POST";
                postRequest.ContentType = "application/json";
                postRequest.ContentLength = bytes.Length;
                postRequest.AllowWriteStreamBuffering = false;
                using (StreamWriter writer = new StreamWriter(postRequest.GetRequestStream()))
                {
                    writer.Write(postJsonData);
                    writer.Flush();
                }
                using (var postResponse = postRequest.GetResponse() as HttpWebResponse)
                {
                    strPostReponse = GetHttpResponse(postResponse, "POST");
                }
            }
            catch (Exception ex)
            {
                strPostReponse = "error";
            }

            return strPostReponse;
        }

        /// <summary>
        /// Http Post Request Async
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postJsonData"></param>
        public static async Task<string> HttpPostRequestAsync(string url, string postJsonData)
        {
            string strPostReponse = string.Empty;
            try
            {
                //var postRequest = CreateHttpRequest(url, "POST", postData);
                var bytes = Encoding.UTF8.GetBytes(postJsonData);
                var postRequest = HttpWebRequest.Create(url) as HttpWebRequest;
                postRequest.KeepAlive = false;
                postRequest.Timeout = 2000;
                postRequest.Method = "POST";
                postRequest.ContentType = "application/json";
                postRequest.ContentLength = bytes.Length;
                postRequest.AllowWriteStreamBuffering = false;
                using (StreamWriter writer = new StreamWriter(await postRequest.GetRequestStreamAsync()))
                {
                    writer.Write(postJsonData);
                    writer.Flush();
                }
                using (var postResponse = await postRequest.GetResponseAsync() as HttpWebResponse)
                {
                    strPostReponse = GetHttpResponse(postResponse, "POST");
                }
            }
            catch (Exception ex)
            {
                strPostReponse = "error";
            }
            
            return strPostReponse;
        }

       
        private static HttpWebRequest CreateGetHttpWebRequest(string url)
        {
            var getRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            getRequest.Method = "GET";
            getRequest.Timeout = 5000;
            getRequest.ContentType = "text/html;charset=UTF-8";
            getRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            return getRequest;
        }

        private static HttpWebRequest CreatePostHttpWebRequest(string url, string postData)
        {
            var postRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            postRequest.KeepAlive = false;
            postRequest.Timeout = 6000;
            postRequest.Method = "POST";
            postRequest.ContentType = "application/json";
            postRequest.ContentLength = postData.Length;
            postRequest.AllowWriteStreamBuffering = false;
            StreamWriter writer = new StreamWriter(postRequest.GetRequestStream(), Encoding.ASCII);
            writer.Write(postData);
            writer.Flush();
            return postRequest;
        }

        private static string GetHttpResponse(HttpWebResponse response, string requestType)
        {
            var responseResult = "";
            const string post = "POST";
            string encoding = "UTF-8";
            if (string.Equals(requestType, post, StringComparison.OrdinalIgnoreCase))
            {
                encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8";
                }
            }
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding)))
            {
                responseResult = reader.ReadToEnd();
            }
            return responseResult;
        }

       
    }
}
