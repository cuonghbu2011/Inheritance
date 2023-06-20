using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class ConverterFacade
    {
        private readonly AnimalServiceResolver _animalServiceResolver;

        public ConverterFacade(AnimalServiceResolver animalServiceResolver)
        {
            _animalServiceResolver = animalServiceResolver;
        }

        public Animal CreateConvert(AnimalDto animal)
        {
            var service = _animalServiceResolver(animal.Type);

            return service.CreateConvert(animal);
        }

        public AnimalDto ConvertToDto(Animal animal)
        {
            //TODO not sure if this works
            var service = _animalServiceResolver(animal.GetType().Name);

            return service.ConvertToDto(animal);
        }
    }
}
