using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class CatConverter : IConverter
    {
        public Animal Convert(AnimalDto value)
        {
            var catDto = value as CatDto;

            return new Cat
            {
                Name = value.Name,
                Id = value.Id,
                IAmCat = catDto.Cat
            };
        }
    }
}
