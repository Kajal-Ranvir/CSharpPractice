using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using HttpClient client = new HttpClient();

        string url = "https://jsonplaceholder.typicode.com/posts/1";

        try
        {
            string response = await client.GetStringAsync(url);

            Console.WriteLine("API Response:");
            Console.WriteLine(response);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}