using AutoMapper;
using BUYList.Application.DTOs;
using BUYList.Domain.Entities;

namespace BUYList.Application.Mappers
{
    public class MappingProfile :
    Profile
    {
        public MappingProfile
        ()
        {
            CreateMap<Item, ItemDTO>().ReverseMap();
        }
    }
}
