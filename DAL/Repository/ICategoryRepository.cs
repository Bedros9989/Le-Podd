using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ICategoryRepository<T>
    {
        List<T> GetAllCategories();
        void InsertCategory(T theObject);
        void UpdateName(int index, string name);
        void DeleteCategory(string index);
        void SaveCategories();

    }
}
