using Newtonsoft.Json;
using UnitTesting.Interfaces;

namespace UnitTesting.Services
{
    public class VideoService
    {
        private readonly IFileReader fileReader;

        public VideoService(
            IFileReader fileReader)
        {
            this.fileReader = fileReader;
        }

        public string ReadVideoTitle()
        {
            var str = new FileReader().Read("C:/Users/ppauleee/Documents/Personal/CSharp/UnitTesting/DataSource/video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);

            if (video == null)
            {
                return "Error parsing the video.";
            }

            return video.Title;
        }
    }

    public class Video
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsProcessed { get; set; }
    }
}