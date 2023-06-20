using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public interface IConverter
    {
        Animal CreateConvert(AnimalDto value);

        AnimalDto ConvertToDto(Animal value);
    }
}
