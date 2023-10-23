﻿
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

        public List<Podcast> GetAll()
        {
            List<Podcast> listAvRegistreradePodcasts = new List<Podcast>();
            try
            {
                listAvRegistreradePodcasts = PodcastSerializer.Deserialize();
            }
            catch (Exception)
            {
            }
            return listAvRegistreradePodcasts;
        }
        /*
        public Podcast GetByName(string podcastName)
        {
            Podcast podcast = null;
            foreach (var item in PodcastSerializer.Deserialize())
            {
                if (item.PodcastName.Equals(podcastName))
                {
                    podcast = item;
                }
            }
            return podcast;
        }
        */

        public List<PodcastEpisode> GetEpisodesByName(string podcastName)
        {
            List<PodcastEpisode> episodesForPodcast = new List<PodcastEpisode>();

            foreach (var podcast in ListAvPodcasts)
            {
                if (podcast.PodcastName == podcastName)
                {
                    episodesForPodcast.AddRange(podcast.Episodes);
                }
            }

            return episodesForPodcast;
        }

        public void Insert(Podcast theObject)
        {
            ListAvPodcasts.Add(theObject);
            SaveChanges();
        }

        public void Update(int index, Podcast theNewObject)
        {
            if (index >= 0)
            {
                ListAvPodcasts[index] = theNewObject;
            }
            SaveChanges();
        }

        public void Delete(string podcastName)
        {
            ListAvPodcasts.RemoveAll(podcast => podcast.PodcastName == podcastName);
            SaveChanges();
        }


        public void SaveChanges()
        {
            PodcastSerializer.Serialize(ListAvPodcasts);
        }
    }
}