using Interitance.Models;
using Interitance.Parameters;
using Interitance.Repositories;

namespace Interitance.Application
{
    public class AnimalService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IAnimalSearch _additionalSearch;

        public AnimalService(IServiceProvider serviceProvider,
            IAnimalSearch additionalSearch)
        {
            _serviceProvider = serviceProvider;
            _additionalSearch = additionalSearch;
        }

        public IList<T> Get<T>() where T : Animal, new()
        {
            return GetInstance<T>().Get();
        }

        public void Create<T>(T entity) where T : Animal, new()
        {
            GetInstance<T>(entity.GetType()).Update(entity);
        }

        public IList<Animal> Search(AninalSearchParams searchParams)
        {
            return _additionalSearch.Search(searchParams);
        }

        private IAnimalRepository<T> GetInstance<T>() where T : Animal, new()
        {
            return GetInstance<T>(typeof(T));
        }

        private IAnimalRepository<T> GetInstance<T>(Type type) where T : Animal, new()
        {
            return _serviceProvider.GetServices<IAnimalRepository<T>>().Single(x => x.Type == type);
        }
    }
}