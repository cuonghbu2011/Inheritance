using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class CatConverter : IConverter
    {
        public AnimalDto ConvertToDto(Animal value)
        {
            var cat = value as Cat;

            return new CatDto
            {
                Name = value.Name,
                Id = value.Id,
                Cat = cat.IAmCat,
                Type = cat.Type,
            };
        }

        public Animal CreateConvert(AnimalDto value)
        {
            var catDto = value as CatDto;

            return new Cat
            {
                Name = value.Name,
                Id = value.Id,
                IAmCat = catDto.Cat,
                Type = value.Type,
            };
        }
    }
}
