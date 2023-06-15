using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class DogConverter : AbstractConverter, IConverter<Dog, DogDto>
    {
        public DogDto Convert(Dog animal)
        {
            var dogDto = base.Convert<Dog, DogDto>(animal);

            dogDto.Dog = animal.IAmDog;

            return dogDto;
        }
    }
}
