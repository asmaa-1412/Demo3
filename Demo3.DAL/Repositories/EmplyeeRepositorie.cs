using Demo3.DAL.Data.Contexts;
using Demo3.DAL.Models.DepartmentModels;
using Demo3.DAL.Models.EmployeeModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.DAL.Repositories
{
    public class EmplyeeRepositorie : IEmplyeeRepositorie
    {
        private readonly ApplicationDbContext _context;
        public EmplyeeRepositorie(ApplicationDbContext context)
        {
            context = _context;
        }
        public Employee? GetById(int id)
        {
            var employee = _context.Employees.Find(id);
            return employee;
        }

        public IEnumerable<Employee> GetAll(bool withTracking = false)
        {
            if (withTracking)
                return _context.Employees.ToList();
            else return _context.Employees.AsNoTracking().ToList();
        }
        public int Add(Employee employee)
        {
            _context.Employees.Add(employee);
            return _context.SaveChanges();
        }

        public int Remove(Employee employee)
        {
            _context.Employees.Update(employee);
            return _context.SaveChanges();
        }

        public int Update(Employee employee)
        {
            _context.Employees.Update(employee);
            return _context.SaveChanges();
        }
    }
}
