using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public interface IConverter<in T, out TResult> where T : Animal where TResult : AnimalDto
    {
        TResult Convert(T input);
    }
}
