using Interitance.Models;

namespace Interitance.Repositories
{
    public interface IAnimalRepository<T> : IBaseRepository where T : Animal
    {
        IList<T> Get();

        void Update(T entity);
    }

    public interface IBaseRepository
    {
        Type Type { get; }
    }
}
