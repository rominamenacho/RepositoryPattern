
using Newtonsoft.Json;
using RepositoryPatternExample.Categories.Model;
using System.Collections.Generic;
using System.IO;

namespace RepositoryPatternExample.Categories.Repository
{
    public class CategoryRepositoryFromFile : IRepository<Category, int>
    {
        public List<Category> GetAll()
        {
            var json = File.ReadAllText(@"C:\Users\54926\source\repos\RepositoryPatternExample\RepositoryPatternExample\Categories\Repository\categories.json");
            //con ruta relativa se rompe el test porque no encuentra el archivo en la carpeta temporal
            //var json = File.ReadAllText(Directory.GetCurrentDirectory() + @"\Categories\Repository\categories.json");
            return JsonConvert.DeserializeObject<List<Category>>(json);
        }


    }
}
