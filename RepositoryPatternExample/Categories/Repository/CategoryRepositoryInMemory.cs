using RepositoryPatternExample.Categories.Model;
using System.Collections.Generic;

namespace RepositoryPatternExample.Categories.Repository
{
    public class CategoryRepositoryInMemory : IRepository<Category, int>
    {
        private List<Category> _categories;


        public CategoryRepositoryInMemory()
        {

            _categories = new List<Category>();
            PutCategoriesOnArray();
        }


        public List<Category> GetAll()
        {
            return _categories;
        }
        private void PutCategoriesOnArray()
        {
            Category monedas = new Category("monedas");
            Category fyv = new Category("fyv");
            Category objetos = new Category("objetos");
            Category profesiones = new Category("profesiones");
            Category paises = new Category("paises");

            monedas.AddWordsToList("Peso");
            monedas.AddWordsToList("Dolar");
            monedas.AddWordsToList("Libra");
            monedas.AddWordsToList("Dolar");
            monedas.AddWordsToList("Libra");

            fyv.AddWordsToList("Cebolla");
            fyv.AddWordsToList("Durazno");
            fyv.AddWordsToList("Limon");
            fyv.AddWordsToList("Durazno");
            fyv.AddWordsToList("Limon");

            objetos.AddWordsToList("Calesita");
            objetos.AddWordsToList("Dinamo");
            objetos.AddWordsToList("libro");
            objetos.AddWordsToList("Dinamo");
            objetos.AddWordsToList("libro");

            profesiones.AddWordsToList("Cocinero");
            profesiones.AddWordsToList("Doctor");
            profesiones.AddWordsToList("Lirico");
            profesiones.AddWordsToList("Abogado");
            profesiones.AddWordsToList("Tecnico");

            paises.AddWordsToList("Canada");
            paises.AddWordsToList("Italia");
            paises.AddWordsToList("Dinamarca");
            paises.AddWordsToList("Australia");
            paises.AddWordsToList("Tailandia");

            _categories.Add(monedas);
            _categories.Add(fyv);
            _categories.Add(objetos);
            _categories.Add(profesiones);
            _categories.Add(paises);
        }
    }
}
