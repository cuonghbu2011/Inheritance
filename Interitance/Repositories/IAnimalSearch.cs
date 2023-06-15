using Interitance.Models;
using Interitance.Parameters;

namespace Interitance.Repositories
{
    public interface IAnimalSearch
    {
        IList<Animal> Search(AninalSearchParams searchParams);
    }
}
