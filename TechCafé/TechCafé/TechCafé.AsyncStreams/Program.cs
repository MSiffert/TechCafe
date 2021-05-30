using System;
using System.Threading.Tasks;

namespace TechCafé.AsyncStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private async Task DisplaySync()
        {
            var video = await Sync.NetflixService.LoadVideo(1);
            
            foreach (var frames in video)
            {
                // Show Frame
            }
        }
        
        private async Task DisplayAsync()
        {
            await foreach (var frames in Async.NetflixService.LoadVideo(1))
            {
                // Show Frame
            }
        }
    }
}