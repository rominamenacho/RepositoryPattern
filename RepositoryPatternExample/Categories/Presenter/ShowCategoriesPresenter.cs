
using RepositoryPatternExample.Categories.UseCase;
using RepositoryPatternExample.Categories.View;

namespace RepositoryPatternExample.Categories.Presenter
{
    public class ShowCategoriesPresenter
    {
        CategoryView _view;
        GetCategoriesAndWordsUseCase _useCase;

        public ShowCategoriesPresenter(CategoryView view)
        {
            _view = view;


            _useCase = new GetCategoriesAndWordsUseCase();
            //  _useCase = new GetCategoriesAndWordsUseCase(this);

        }

        public void GetCategories()
        {
            _view.PrintCategoryOnConsole(_useCase.GetCategoriesFromRepository());

        }


    }
}
