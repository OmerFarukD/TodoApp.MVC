using AutoMapper;
using TodoApp.MVC.Models;

namespace TodoApp.MVC.MappingProfiles;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<ToDo,TodoResponseDto>();
    }
}
