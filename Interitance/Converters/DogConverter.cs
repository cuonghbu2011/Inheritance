using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class DogConverter : IConverter
    {
        public Animal Convert(AnimalDto value)
        {
            var dogDto = value as DogDto;

            return new Dog
            {
                Id = value.Id,
                Name = value.Name,
                IAmDog = dogDto.Dog
            };
        }
    }
}
