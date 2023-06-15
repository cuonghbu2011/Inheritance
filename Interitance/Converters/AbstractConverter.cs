using Interitance.Dtos;
using Interitance.Models;

namespace Interitance.Converters
{
    public abstract class AbstractConverter
    {
        public virtual TResult Convert<T, TResult>(T animal) where T : Animal where TResult : AnimalDto, new()
        {
            return new TResult
            {
                Id = animal.Id,
                Name = animal.Name
            };
        }
    }
}
