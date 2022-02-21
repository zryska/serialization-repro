using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using SerializationBehavior.DataModel;

namespace SerializationBehavior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car
            {
                Id = Guid.NewGuid().ToString(),
                Name = "name",
                Description = "description",
            };

            var serializedBytes = JsonSerializer.SerializeToUtf8Bytes(car);

            Console.WriteLine(Encoding.UTF8.GetString(serializedBytes));
        }
    }
}
