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

        public object Convert<T>(T animal) where T : Animal
        {
            var service = _animalServiceResolver(animal.GetType().Name);

            return service.Convert(animal);
        }
    }
}
