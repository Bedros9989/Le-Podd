using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Windows.Forms;
using System.Linq;

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

        public void Create<T>(T item)
        {
            if (item is Category category)
            {
                categoryRepository.InsertCategory(category);
            }
            else if (item is Podcast podcast)
            {
                podcastRepository.Insert(podcast);
            }
        }

        public void Delete(string item, bool isCategory = false)
        {
            if (isCategory)
            {
                categoryRepository.DeleteCategory(item);
            }
            else
            {
                podcastRepository.Delete(item);
            }
        }

        public List<T> RetrieveAll<T>(string category = null)
        {
            if (typeof(T) == typeof(Category))
            {
                return categoryRepository.GetAllCategories() as List<T>;
            }
            else if (typeof(T) == typeof(Podcast))
            {
                return podcastRepository.GetAll(category) as List<T>;
            }
            else
            {
                return null;
            }
        }

        public async Task<SyndicationFeed> FetchRssDataAsync(string rssUrl)
        {
            if (!Uri.IsWellFormedUriString(rssUrl, UriKind.Absolute))
            {
                MessageBox.Show("Fel URL");
                return null;
            }
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
            List<Podcast> allPodcasts = podcastRepository.GetAll();
            return allPodcasts.Where(podcast => podcast.Category == category).ToList();

        }

        public void Update(int index, string newValue, string propertyName = null)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                categoryRepository.UpdateName(index, newValue); 
            }
            else
            {
                switch (propertyName)
                {
                    case "Name":
                        podcastRepository.Update(index, newValue, null);
                        break;
                    case "Category":
                        podcastRepository.Update(index, null, newValue); 
                        break;
                    default:
                        throw new ArgumentException("Invalid property name");
                }
            }
        }
    }
}
