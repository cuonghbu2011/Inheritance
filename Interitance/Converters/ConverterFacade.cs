using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class ConverterFacade
    {
        private readonly IServiceProvider _serviceProvider;

        public ConverterFacade(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public object Convert<T>(T animal)
        {
            switch (animal)
            {
                case Dog dog:
                    var converter = (IConverter<Dog, DogDto>)_serviceProvider.GetRequiredService(typeof(IConverter<Dog, DogDto>));

                    return (object)converter.Convert(dog);

                case Cat cat:
                    var converter01 = (IConverter<Cat, CatDto>)_serviceProvider.GetRequiredService(typeof(IConverter<Cat, CatDto>));

                    return (object)converter01.Convert(cat);
                default:
                    break;
            }

            return null;
        }
    }
}
