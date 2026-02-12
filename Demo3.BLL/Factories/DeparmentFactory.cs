using Demo3.BLL.DTOs.DepartmentDtos;
using Demo3.DAL.Models.DepartmentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.BLL.Factories
{
    static class DeparmentFactory
    {
        public static DepartmentDto ToDepartmentDto(this Department department)
        {
            return new DepartmentDto(){
                DeptId = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                DateOfCreation = DateOnly.FromDateTime(department.CreatedOn),
            };
        }
        public static Department ToEntity(this CreatedDepartmentDto createdDepartment)
        {
            return new Department()
            {
                Name = createdDepartment.Name,
                Code = createdDepartment.Code,
                Description = createdDepartment.Description,
                CreatedOn =createdDepartment.DateOfCreation.ToDateTime(new TimeOnly())
            };
        }
        public static Department ToEntity(this UpdateDepartmentDto UpdateDepartment)
        {
            return new Department()
            {
                Id= UpdateDepartment.Id,
                Name = UpdateDepartment.Name,
                Code = UpdateDepartment.Code,
                Description = UpdateDepartment.Description,
                CreatedOn = UpdateDepartment.DateOfCreation.ToDateTime(new TimeOnly())
            };
        }
    }
    
}
