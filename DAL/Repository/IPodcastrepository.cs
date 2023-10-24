using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL.Repository
{
    public interface IPodcastrepository<T>
    {
        List<T> GetAll();
        List<Podcast> GetByCategory(string category);
        List<PodcastEpisode> GetEpisodesByName(string name);
        PodcastEpisode GetEpisode(string title);
        void Insert(T theObject);
        void Update(int index, string name, string newCategory);
        void Delete(string index);
        void SaveChanges();

    }
}
