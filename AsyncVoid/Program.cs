using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncVoid
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
               AsyncVoid();

                Console.WriteLine("Hello World!");

                await AsyncTask();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static async void AsyncVoid()
        {
            
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"http://localhost:50000");

                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }
        }


        static async Task AsyncTask()
        {

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"http://localhost:50000");

                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
        }

    }
}
