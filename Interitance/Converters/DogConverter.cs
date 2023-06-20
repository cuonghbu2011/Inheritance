using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class DogConverter : IConverter
    {
        public AnimalDto ConvertToDto(Animal value)
        {
            var dog = value as Dog;

            return new DogDto
            {
                Name = value.Name,
                Id = value.Id,
                Dog = dog.IAmDog
            };
        }

        public Animal CreateConvert(AnimalDto value)
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
