using Interitance.Models;

namespace Interitance.Repositories
{
    public interface IAnimalRepository<T> where T : Animal
    {
        IList<T> Get();

        void Update(T entity);
    }
}
