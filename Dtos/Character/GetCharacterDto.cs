using Dotnet.Models;

namespace Dotnet.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Grzegorz";

        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 9;
        public int Defense { get; set; } = 7;
        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Paladin;
    }
}