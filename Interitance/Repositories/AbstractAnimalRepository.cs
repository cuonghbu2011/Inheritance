using Interitance.Models;

namespace Interitance.Repositories
{
    public abstract class AbstractAnimalRepository<T> where T : Animal, new()
    {
        public virtual void Update(T entity)
        {
        }
    }
}
