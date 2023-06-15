using Interitance.Models;
using Interitance.Parameters;
using Interitance.Repositories;

namespace Interitance.Application
{
    public class AdditionalService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IAnimalSearch _additionalSearch;

        public AdditionalService(IServiceProvider serviceProvider,
            IAnimalSearch additionalSearch)
        {
            _serviceProvider = serviceProvider;
            _additionalSearch = additionalSearch;
        }

        public IList<T> Get<T>() where T : Animal, new()
        {
            var service = (IAnimalRepository<T>)_serviceProvider.GetRequiredService(typeof(IAnimalRepository<T>));

            return service.Get();
        }

        public void Update<T>(T entity) where T : Animal, new()
        {
            var service = (IAnimalRepository<T>)_serviceProvider.GetRequiredService(typeof(IAnimalRepository<T>));

            service.Update(entity);
        }

        public IList<Animal> Search(AninalSearchParams searchParams)
        {
            return _additionalSearch.Search(searchParams);
        }
    }
}