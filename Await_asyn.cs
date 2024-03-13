using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NCCLabSuravi33
{
    internal class Await_asyn
    {
        static async Task Main(string[] args)
        {
            // Start asynchronous task
            await DownloadContentAsync();

            Console.WriteLine("Task completed. Press any key to exit.");
            Console.ReadKey();
        }

        static async Task DownloadContentAsync()
        {
            // Create HttpClient instance
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send asynchronous GET request
                    HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");

                    // Check if request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read and print content
                        string content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Content downloaded successfully:");
                        Console.WriteLine(content);
                    }
                    else
                    {
                        Console.WriteLine($"Failed to download content. Status code: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    
                }
                Console.WriteLine("\nLab No.: 17\tName: Suravi Shrestha\tRoll No: 33/26472");
            }
        }
    }
}
