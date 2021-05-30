using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechCafé.AsyncStreams.Sync
{
    public class VideoRepository
    {
        public static Task<IEnumerable<byte[]>> LoadVideo(int videoId)
        {
            var frames = new List<byte[]>
            {
                new byte[] {0x00, 0x05, 0x09}, 
                new byte[] {0x00, 0x05, 0x09}, 
                new byte[] {0x00, 0x05, 0x09}
            };

            return Task.FromResult(frames.AsEnumerable());
        }
    }
}