using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;


namespace BLL
{
    public class PodcastManager
    {
        IPodcastrepository<Podcast> podcastRepository;
        ICategoryRepository<Category> categoryRepository;

        public PodcastManager()
        {
            podcastRepository = new PodcastRepository();
            categoryRepository = new CategoryRepository();
        }

        /*
        public void CreatePodcast(string podcastName, string title, string url, string category, int AntalAvsnitt)
        {
            Podcast podd = new Podcast(podcastName, title, url, category, AntalAvsnitt);
            podcastRepository.Insert(podd);
        }
        */

        public void CreateEnPodcast(Podcast podcast)
        {
            podcastRepository.Insert(podcast);
        }


        public void DeletePodcast(string podcastName) 
        {
            podcastRepository.Delete(podcastName);

        }

        public List<Podcast> RetrieveAllPodcasts()
        {
            return podcastRepository.GetAll();
        }

        public SyndicationFeed FetchRssData(string rssUrl)
        {
            try
            {
                XmlReader reader = XmlReader.Create(rssUrl);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                return feed;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching RSS data: " + ex.Message);
                return null;
            }

        }

        public List<PodcastEpisode> RetrieveAllPodcastEpisodes(string namn)
        {
            return podcastRepository.GetEpisodesByName(namn);
        }

        public List<Category> RetrieveAllCategories()
        {
            return categoryRepository.GetAllCategories();
        }

        public void CreateEnCategory(Category category)
        {
            categoryRepository.InsertCategory(category);
        }

        public void DeleteACategory(string category)
        {
            categoryRepository.DeleteCategory(category);

        }


    }
}
