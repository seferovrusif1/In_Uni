using System.Net.Http;
using System.Text.Json;
using System.Diagnostics;

namespace Async_non_async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> links = new List<string>
        {
            "http://www.contoso.com/",
            "https://lms.code.edu.az/index",
            "https://www.youtube.com/"
        };

            nonnaasync(links);
            aasync(links);
            Console.ReadLine();
            //Stopwatch sw = Stopwatch.StartNew();
            //async("http://www.contoso.com/").Wait();
            //async("https://lms.code.edu.az/index").Wait();
            //async("https://www.youtube.com/").Wait();
            //Console.WriteLine("Total async: " + sw.ElapsedMilliseconds);
            //Stopwatch sww = Stopwatch.StartNew();
            //nonasync("http://www.contoso.com/");
            //nonasync("https://lms.code.edu.az/index");
            //nonasync("https://www.youtube.com/");
            //Console.WriteLine("Total non-async: " + sww.ElapsedMilliseconds);


        }


        static readonly HttpClient client = new HttpClient();

        #region tek link ile non async ve async methodlar
        static async Task async(string link)
        {

            try
            {
                using HttpResponseMessage response = await client.GetAsync(link);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Message :{0} ", e.Message);
            }

        }
        static void nonasync(string link)
        {

            try
            {
                using HttpResponseMessage response = client.GetAsync(link).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        #endregion

        #region link listi  ile non async ve async methodlar

        static async Task aasync(List<string> links)
        {
            Stopwatch sww = Stopwatch.StartNew();

            foreach (var item in links)
            {
                try
                {
                    using HttpResponseMessage response = await client.GetAsync(item);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
            Console.WriteLine("Total async: " + sww.ElapsedMilliseconds);

        }
        static void  nonnaasync(List<string> links)
        {
            Stopwatch sw = Stopwatch.StartNew();

            foreach (var item in links)
            {
                try
                {
                    using HttpResponseMessage response = client.GetAsync(item).Result;
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Message :{0} ", e.Message);
                }
            }
            Console.WriteLine("Total non-async: " + sw.ElapsedMilliseconds);

        }
        #endregion
    }
}
   