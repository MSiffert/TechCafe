using System.Collections.Generic;

namespace TechCafé.AsyncStreams.Async
{
    public class NetflixService
    {
        public static async IAsyncEnumerable<byte[]> LoadVideo(int videoId)
        {
            yield return await VideoRepository.LoadFrames(videoId, 0);
            yield return await VideoRepository.LoadFrames(videoId, 3);
            yield return await VideoRepository.LoadFrames(videoId, 6);
            yield return await VideoRepository.LoadFrames(videoId, 9);
            yield return await VideoRepository.LoadFrames(videoId, 12);
        }
    }
}