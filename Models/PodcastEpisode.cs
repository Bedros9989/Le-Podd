using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class PodcastEpisode
    {
        public string EpisodeName { get; set; }
        public string Description { get; set; }

        public PodcastEpisode() 
        {
        }

        public PodcastEpisode(string episodeName, string description)
        {
            EpisodeName = episodeName;
            Description = description;

        }

    }
}
