using System.Threading.Tasks;

namespace TechCafé.AsyncStreams.Async
{
    public class VideoRepository
    {
        public static Task<byte[]> LoadFrames(int videoId, int offset)
        {
            return Task.FromResult(new byte[] { 0x00, 0x05, 0x09 }); 
        }
    }
}