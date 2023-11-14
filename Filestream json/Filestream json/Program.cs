using Filestream_json.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json.Serialization;

namespace Filestream_json
{
    internal class Program
    {
        //public static string Root = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
        public static string Root = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
        static void Main(string[] args)
        {
            //Console.WriteLine(Root);
            //C: \Users\Birinci novbe\Desktop\New folder\Filestream json\Filestream json\NewFolder\
            if (!Directory.Exists(Path.Combine(Root, "Models")))
            {
                Directory.CreateDirectory(Path.Combine(Root, "Models"));
            }
            if (!Directory.Exists(Path.Combine(Root, "Data")))
            {
                Directory.CreateDirectory(Path.Combine(Root, "Data"));
            }
            if (!File.Exists(Path.Combine(Root, "Data", "jsonData.json")))
            {
                File.Create(Path.Combine(Root, "Data", "jsonData.json"));
            }





            HttpClient client = new HttpClient();
            
            string data = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
            var a= JsonConvert.DeserializeObject<List<CustomObject>>(data);
            
            string strData = JsonConvert.SerializeObject(a);
            StreamWriter sw = new StreamWriter(Path.Combine(Root, "Data", "jsonData.json"));
            sw.WriteLine(strData);
            sw.Close();
            // StreamReader sr = new StreamReader(Path.Combine(Root, "Data", "jsonData.json"));
            // Console.WriteLine(sr.ReadToEnd());


            //using (StreamWriter sw = new StreamWriter(Path.Combine(Root, "Data", "jsonData.json")))
            //{
            //    sw.WriteLine(strData);
            //}
        }

    }
}