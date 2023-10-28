
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PodcastRepository : IPodcastrepository<Podcast>

    {
        Serializer<Podcast> PodcastSerializer;
        List<Podcast> ListAvPodcasts;

        public PodcastRepository()
        {
            ListAvPodcasts = new List<Podcast>();
            PodcastSerializer = new Serializer<Podcast>(nameof(ListAvPodcasts));

            try
            {
                ListAvPodcasts = PodcastSerializer.Deserialize();
            }
            catch (Exception)
            {
                ListAvPodcasts = new List<Podcast>();
            }
        }

        public List<Podcast> GetAll(string category = null)
        {
            List<Podcast> listAvRegistreradePodcasts = new List<Podcast>();
            try
            {
                listAvRegistreradePodcasts = PodcastSerializer.Deserialize();
            }
            catch (Exception)
            {
                
            }

            if (category != null)
            {
                return listAvRegistreradePodcasts.Where(podcast => podcast.Category == category).ToList();
            }

            return listAvRegistreradePodcasts;
        }

        public List<PodcastEpisode> GetEpisodesByName(string title)
        {
            List<PodcastEpisode> episodesForPodcast = new List<PodcastEpisode>();

            foreach (var podcast in ListAvPodcasts)
            {
                if (podcast.Title == title)
                {
                    episodesForPodcast.AddRange(podcast.Episodes);
                }
            }

            return episodesForPodcast;
        }

        public PodcastEpisode GetEpisode(string title){
            foreach (var podcast in ListAvPodcasts)
            {
                foreach (var episode in podcast.Episodes)
                {
                    if (episode.EpisodeName == title)
                    {
                        return episode;
                    }
                }
            }

            return null;
        }

        public void Insert(Podcast theObject)
        {
            ListAvPodcasts.Add(theObject);
            SaveChanges();
        }

        public void Update(int index, string newName = null, string newCategory = null)
        {
            if (index >= 0 && index < ListAvPodcasts.Count)
            {
                Podcast existingPodcast = ListAvPodcasts[index];

                if (newName != null)
                {
                    existingPodcast.PodcastName = newName;
                }

                if (newCategory != null)
                {
                    existingPodcast.Category = newCategory;
                }

                SaveChanges();
            }
            else
            {

            }
        }

        public void Delete(string title)
        {
            ListAvPodcasts.RemoveAll(podcast => podcast.Title == title);
            SaveChanges();
        }

        public void SaveChanges()
        {
            PodcastSerializer.Serialize(ListAvPodcasts);
        }
    }
}
