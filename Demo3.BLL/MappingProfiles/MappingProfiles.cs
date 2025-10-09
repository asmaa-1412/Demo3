using AutoMapper;
using Demo3.BLL.DTOs.EmployeeDtos;
using Demo3.DAL.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.BLL.MappingProfiles
{
    public class MappingProfiles :Profile
    {
        public MappingProfiles()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            //CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, EmployeeDetailsDto>().ReverseMap();
            CreateMap<Employee, CreatedEmployeeDto>().ReverseMap();
            CreateMap<Employee, UpdatedEmployeeDto>().ReverseMap();
        }
    }
}
