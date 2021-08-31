using System;
using System.Text.Json.Serialization;

namespace Dotnet.Models
{
    // By zamiast numerków były NAZWY 
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric,
        Paladin
    }


}
