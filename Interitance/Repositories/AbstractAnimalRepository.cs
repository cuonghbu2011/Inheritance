using Interitance.Models;

namespace Interitance.Repositories
{
    public abstract class AbstractAnimalRepository<T> where T : Animal, new()
    {
        public abstract IList<T> Get();

        public virtual void Update(T entity)
        {
        }
    }
}
