using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IPodcastrepository<T>
    {
        List<T> GetAll();
        //T GetByName(string podcastName);
        List<PodcastEpisode> GetEpisodesByName(string name);
        void Insert(T theObject);
        void Update(int index, T theObject);
        void Delete(string index);
        void SaveChanges();
    }
}
