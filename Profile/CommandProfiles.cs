using AutoMapper;
using webapidotnetcore.Dto;
using webapidotnetcore.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}