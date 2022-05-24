using RepositoryPatternExample.Categories.Presenter;
using RepositoryPatternExample.Categories.View;

namespace RepositoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {



            CategoryView view = new CategoryView();
            ShowCategoriesPresenter _presenter = new ShowCategoriesPresenter(view);

            _presenter.GetCategories();
        }
    }
}
