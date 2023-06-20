using Interitance.Models;

namespace Interitance.Repositories
{
    public class CatRepository : AbstractAnimalRepository<Cat>, IAnimalRepository<Cat>
    {
        public IList<Cat> Get()
        {
            return new List<Cat>();
        }
    }
}
