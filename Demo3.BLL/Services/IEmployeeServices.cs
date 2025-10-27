using Demo3.BLL.DTOs.DepartmentDtos;
using Demo3.BLL.DTOs.EmployeeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.BLL.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<EmployeeDto> GetAllEmployees(string? EmployeeSearchName);
        EmployeeDetailsDto? GetById(int id);
        public int AddEmployee(CreatedEmployeeDto emp);
        public int UpdateEmployee(UpdatedEmployeeDto emp);
        public bool DeleteEmployee(int id);
    }
}
