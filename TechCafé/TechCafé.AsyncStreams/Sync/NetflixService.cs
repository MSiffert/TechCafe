using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechCafé.AsyncStreams.Sync
{
    public class NetflixService
    {
        public static async Task<IEnumerable<byte[]>> LoadVideo(int videoId)
        {
            return await VideoRepository.LoadVideo(videoId);
        }
    }
}