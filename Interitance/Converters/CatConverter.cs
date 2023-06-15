using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class CatConverter : AbstractConverter, IConverter<Cat, CatDto>
    {
        public CatDto Convert(Cat animal)
        {
            var catDto = base.Convert<Cat, CatDto>(animal);

            catDto.Cat = animal.IAmCat;

            return catDto;
        }
    }
}
