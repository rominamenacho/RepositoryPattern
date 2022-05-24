using System.Collections.Generic;

namespace RepositoryPatternExample.Categories.Repository
{
    public interface IRepository<T1, T2> where T1 : class
    {
        List<T1> GetAll();
    }
}
