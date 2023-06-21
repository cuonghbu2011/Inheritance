using Interitance.Models;
using Interitance.Parameters;

namespace Interitance.Repositories
{
    public class AnimalRepository :
        AbstractAnimalRepository<Animal>,
        IAnimalRepository<Animal>,
        IAnimalSearch
    {
        public Type Type => typeof(Animal);

        public IList<Animal> Get()
        {
            var results = new List<Animal>();

            results.Add(new Dog()
            {
                IAmDog = "gau gau gau"
            } as Animal);
            results.Add(new Cat()
            {
                IAmCat = "meo meo meo"
            } as Animal);

            return results;
        }

        public IList<Animal> Search(AninalSearchParams searchParams)
        {
            return Get();
        }
    }
}
