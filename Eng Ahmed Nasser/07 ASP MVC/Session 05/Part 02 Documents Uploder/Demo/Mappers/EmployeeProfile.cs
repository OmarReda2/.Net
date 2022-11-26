using AutoMapper;
using Demo.DAL.Entities;
using Demo.Models;

namespace Demo.Mappers
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
        }
    }
}
