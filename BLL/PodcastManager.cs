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

   
        public void CreatePodcast(string podcastName, string title, string url, string category, int AntalAvsnitt)
        {
            Podcast podd = new Podcast(podcastName, title, url, category, AntalAvsnitt);
        }
        

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

        public async Task<SyndicationFeed> FetchRssDataAsync(string rssUrl)
        {
            try
            {
                SyndicationFeed feed = await Task.Run(() =>
                {
                    XmlReader reader = XmlReader.Create(rssUrl);
                    return SyndicationFeed.Load(reader);
                });
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

        public PodcastEpisode RetrieveEpisode(string title)
        {
            return podcastRepository.GetEpisode(title);
        }

        public List<Podcast> SortByCategory(string category)
        {
            return podcastRepository.GetByCategory(category);
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

        public void UpdatePodcastName(int index, string newName)
        {
            podcastRepository.UpdateName(index, newName);
        }

        public void UpdatePodcastCategory(int index, string newCategory)
        {
            podcastRepository.UpdateCategory(index, newCategory);
        }

        public void UpdateCategoryName(int index, string newName)
        {
            categoryRepository.UpdateName(index, newName);
        }

    }
}
