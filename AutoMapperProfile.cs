using AutoMapper;
using Dotnet.Dtos.Character;
using Dotnet.Models;

namespace Dotnet
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();

        }
    }
}