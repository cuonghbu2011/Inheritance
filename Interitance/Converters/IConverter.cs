using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public interface IConverter
    {
        Animal Convert(AnimalDto value);
    }
}
