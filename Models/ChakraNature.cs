using System.Text.Json.Serialization;

namespace dotnet_seven.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ChakraNature
    {
        WIND = 0,
        WATER = 1,
        FIRE = 2,
        EARTH = 3,
        LIGHTNENIG = 4
    }
}