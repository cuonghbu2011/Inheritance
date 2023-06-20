using Interitance.Models;

namespace Interitance.Repositories
{
    public class DogRepository : AbstractAnimalRepository<Dog>, IAnimalRepository<Dog>
    {
        public IList<Dog> Get()
        {
            return new List<Dog>();
        }
    }
}
