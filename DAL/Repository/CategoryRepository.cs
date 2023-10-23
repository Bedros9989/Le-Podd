using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        Serializer<Category> categorySerializer;
        List<Category> ListAvCategories;

        public CategoryRepository()
        {
            categorySerializer = new Serializer<Category>(nameof(ListAvCategories));
            ListAvCategories = categorySerializer.Deserialize() ?? new List<Category>();
        }

        public List<Category> GetAllCategories()
        {
            return ListAvCategories;
        }

        public void InsertCategory(Category category)
        {
            ListAvCategories.Add(category);
            SaveCategories();
        }

        public void DeleteCategory(string categoryName)
        {
            Category categoryToDelete = ListAvCategories.Find(c => c.Name == categoryName);
            if (categoryToDelete != null)
            {
                ListAvCategories.Remove(categoryToDelete);
                SaveCategories();
            }
        }

        public void UpdateName(int index, string newName)
        {
            if (index >= 0)
            {
                Category existingCategory = ListAvCategories[index];
                existingCategory.Name = newName;
                SaveCategories();
            }
        }

        public void SaveCategories()
        {
            categorySerializer.Serialize(ListAvCategories);
        }


    }

    

}
