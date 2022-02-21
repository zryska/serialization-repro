using System.Text.Json.Serialization;

namespace SerializationBehavior.DataModel
{
    public class Car : ItemBase
    {
        [JsonPropertyName("CarId")]
        public override string Id { get; set; }
    }
}
