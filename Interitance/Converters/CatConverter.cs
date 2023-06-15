using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public class CatConverter : AbstractConverter, IConverter
    {
        public object Convert(object animal)
        {
            var cat = (Cat)animal;
            var catDto = base.Convert<Cat, CatDto>(cat);

            catDto.Cat = cat.IAmCat;

            return (object)catDto;
        }
    }
}
