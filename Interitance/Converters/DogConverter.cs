using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class DogConverter : AbstractConverter, IConverter
    {
        public object Convert(object animal)
        {
            var dog = (Dog)animal;
            var dogDto = base.Convert<Dog, DogDto>(dog);

            dogDto.Dog = dog.IAmDog;

            return (object)dogDto;
        }
    }
}
