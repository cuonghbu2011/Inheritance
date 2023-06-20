using System.Runtime.Serialization;
using JsonSubTypes;
using Newtonsoft.Json;

namespace Interitance.Dtos
{
    [DataContract(Name = "AdditionalRepayment")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(CatDto), "Cat")]
    [JsonSubtypes.KnownSubType(typeof(DogDto), "Dog")]
    public class AnimalDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}
