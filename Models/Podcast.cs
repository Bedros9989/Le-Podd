using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Podcast
    {
        public string PodcastName { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string URL { get; set; }
        public List<PodcastEpisode> Episodes { get; set; }
        public int AntalAvsnitt { get; set; }

        public Podcast()
        {
            Episodes = new List<PodcastEpisode>();
        }

        public Podcast(string podcastName, string title, string url, string category, int antalAvsnitt)
        {
            PodcastName = podcastName;
            Title = title;
            URL = url;
            Category = category;
            AntalAvsnitt = antalAvsnitt;
            Episodes = new List<PodcastEpisode>();

        }

    }
   
}
