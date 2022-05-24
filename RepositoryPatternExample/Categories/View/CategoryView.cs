using RepositoryPatternExample.Categories.Model;
using System;
using System.Collections.Generic;

namespace RepositoryPatternExample.Categories.View
{
    public class CategoryView
    {

        public CategoryView()
        {

        }

        public virtual void PrintCategoryOnConsole(List<Category> categories)
        {

            foreach (var item in categories)
            {
                Console.WriteLine("category: " + item.Name);
            }
            Console.ReadKey();

        }
    }
}
