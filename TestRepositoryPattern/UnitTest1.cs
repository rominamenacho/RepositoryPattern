using NSubstitute;
using NUnit.Framework;
using RepositoryPatternExample.Categories.Model;
using RepositoryPatternExample.Categories.Presenter;
using RepositoryPatternExample.Categories.UseCase;
using RepositoryPatternExample.Categories.View;
using System.Collections.Generic;
using System.Linq;

namespace TestRepositoryPattern
{
    public class Tests
    {

        [Test]
        public void Categories_in_json_should_have_items()
        {
            //   IRepository<Category, int> repoJSON = new CategoryRepositoryFromFile();

            //si mando el repo por parametro al caso de uso, en el presentador tengo acceso a model y a repository
            GetCategoriesAndWordsUseCase _useCase = new GetCategoriesAndWordsUseCase();

            List<Category> categories = _useCase.GetCategoriesFromRepository();

            Assert.That(categories.Count(), Is.EqualTo(9));
        }

        //[Test]
        //public void Categories_in_memory_should_have_items()
        //{
        //    //   IRepository<Category, int> inMemory = new CategoryRepositoryInMemory();

        //    GetCategoriesAndWordsUseCase _useCase = new GetCategoriesAndWordsUseCase();

        //    List<Category> categories = _useCase.GetCategoriesFromRepository();

        //    Assert.That(categories.Count(), Is.EqualTo(5));
        //}

        [Test]
        public void TestViewRecievedData()
        {
            //given
            CategoryView _view = Substitute.For<CategoryView>();
            ShowCategoriesPresenter _presenter = new ShowCategoriesPresenter(_view);

            //when
            _presenter.GetCategories();

            //then
            _view.Received();
        }
    }
}