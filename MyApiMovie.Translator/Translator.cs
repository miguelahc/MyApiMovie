using System;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Web;
using System.Media;
using MyApiMovie.Translator.TokenAccess;

namespace MyApiMovie.Translator
{
    public class Translator
    {
        public string sourceText { set; get; }
        public string fromLanguage { set; get; }
        public string toLanguage { set; get; }
        string URI = Configuration.TranslatorURI;

        public Translator() { }

        
        public string Translate()
        {
            TokenAccess.AdmAccessToken admToken;
            string headerValue;
            TokenAccess.AdmAuthentication admAuth = new TokenAccess.AdmAuthentication(Configuration.TranslatorUserId, Configuration.TranslatorUserKey);
            try
            {
                admToken = admAuth.GetAccessToken();
                headerValue = "Bearer " + admToken.access_token;
                return Translate(headerValue);
            }
            catch (WebException e)
            {
                ProcessWebException(e);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
            }
            return "";
        }
        private static void ProcessWebException(WebException e)
        {
            Console.WriteLine("{0}", e.ToString());
            string strResponse = string.Empty;
            using (HttpWebResponse response = (HttpWebResponse)e.Response)
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(responseStream, System.Text.Encoding.ASCII))
                    {
                        strResponse = sr.ReadToEnd();
                    }
                }
            }
            Console.WriteLine("Http status code={0}, error message={1}", e.Status, strResponse);
        }

        private string Translate(string authToken)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Format(URI, System.Web.HttpUtility.UrlEncode(sourceText), fromLanguage, toLanguage));
            httpWebRequest.Headers.Add("Authorization", authToken);
            WebResponse response = null;
            try
            {
                response = httpWebRequest.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    System.Runtime.Serialization.DataContractSerializer dcs = new System.Runtime.Serialization.DataContractSerializer(Type.GetType("System.String"));
                    return (string)dcs.ReadObject(stream);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                    response = null;
                }
            }
        }

    }
}
