using AutoMapper;
using Demo3.BLL.DTOs.DepartmentDtos;
using Demo3.BLL.DTOs.EmployeeDtos;
using Demo3.DAL.Models.EmployeeModels;
using Demo3.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.BLL.Services
{
    public class EmployeeServices(IEmplyeeRepositorie _employeeRepositorie, IMapper _mapper ) : IEmployeeServices
    {
        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            var emp = _employeeRepositorie.GetAll();
            var empdto = _mapper.Map<IEnumerable<EmployeeDto>>(emp);
            return empdto;
        }
        public EmployeeDetailsDto? GetById(int id)
        {

            var emp = _employeeRepositorie.GetById(id);
            if (emp is null) return null;
            else
            {
                var empToReturn = _mapper.Map<EmployeeDetailsDto>(emp);
                return empToReturn;
            }
        }
        public int AddEmployee(CreatedEmployeeDto emp)
        {
            var employee = _mapper.Map<Employee>(emp);
            return _employeeRepositorie.Add(employee);
        }


        public int UpdateEmployee(UpdatedEmployeeDto emp)
        {
            var employee = _mapper.Map<Employee>(emp);
            return _employeeRepositorie.Update(employee);
        }

        public bool DeleteEmployee(int id)
        {
            var employee = _employeeRepositorie.GetById(id);
            if (employee is null) return false;
            else
            {
                employee.IsDeleted = true;
                return _employeeRepositorie.Update(employee)>0? true : false ;
            }
        }
    }
}
