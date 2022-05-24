using RepositoryPatternExample.Categories.Model;
using RepositoryPatternExample.Categories.Repository;
using System.Collections.Generic;

namespace RepositoryPatternExample.Categories.UseCase
{
    public class GetCategoriesAndWordsUseCase
    {
        IRepository<Category, int> _repository;
        // ShowCategoriesPresenter _presenter;

        //public GetCategoriesAndWordsUseCase(ShowCategoriesPresenter presenter)
        //{
        //    _repository = new CategoryRepositoryFromFile();
        //    _presenter = presenter;
        //}

        public GetCategoriesAndWordsUseCase()
        {
            _repository = new CategoryRepositoryFromFile();
        }

        public virtual List<Category> GetCategoriesFromRepository()
        {
            return _repository.GetAll();
        }

    }
}
