using Demo3.BLL.DTOs.DepartmentDtos;
using Demo3.BLL.Factories;
using Demo3.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.BLL.Services
{
    public class DepartmentServices(IDepartmentRepositorie _deptrepositorie) : IDepartmentServices
    {

        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var depts = _deptrepositorie.GetAll();
            var departmentsToReturn = depts.Select(d => d.ToDepartmentDto());
            return departmentsToReturn;
        }
        public DepartmentDetailsDto? GetById(int id)
        {
            var dept = _deptrepositorie.GetById(id);
            if (dept is null) return null;
            else
            {
                var deptToReturn = new DepartmentDetailsDto()
                {
                    Id = dept.Id,
                    Code = dept.Code,
                    Name = dept.Name,
                    CreatedBy = dept.CreatedBy,
                    LastModifiedBy = dept.LastModifiedBy,
                    IsDeleted = dept.IsDeleted,
                    DateOfCreation = DateOnly.FromDateTime(dept.CreatedOn),
                    LastModifiedOn = DateOnly.FromDateTime(dept.LastModifiedOn),
                };
                return deptToReturn;
            }
        }
        public int AddDepartment(CreatedDepartmentDto dept)
        {
            return _deptrepositorie.Add(dept.ToEntity());
        }
        public int UpdateDepartment(UpdateDepartmentDto dto)
        {
            return _deptrepositorie.Update(dto.ToEntity());
        }
        public bool DeleteDepartment(int id)
        {
            var dept = _deptrepositorie.GetById(id);
            if (dept is null) return false;
            else
            {
                var res = _deptrepositorie.Remove(dept);
                if (res > 0) return true;
                else return false;
            };
        }
    }
}
