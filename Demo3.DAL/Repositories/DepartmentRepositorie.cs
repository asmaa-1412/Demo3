using Demo3.DAL.Data.Contexts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo3.DAL.Models.DepartmentModels;

namespace Demo3.DAL.Repositories
{
    public class DepartmentRepositorie : IDepartmentRepositorie
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRepositorie(ApplicationDbContext context)
        {
            _context = context;
        }
        public Department? GetById(int id)
        {
            var department = _context.Departments.Find(id);
            return department;
        }
        public IEnumerable<Department> GetAll(bool withTracking = false)
        {
            if (withTracking)
                return _context.Departments.ToList();
            else return _context.Departments.AsNoTracking().ToList();
        }


        public int Add(Department department)
        {
            _context.Departments.Add(department);
            return _context.SaveChanges();

        }
        public int Update(Department department)
        {
            _context.Departments.Update(department);
            return _context.SaveChanges();

        }
        public int Remove(Department department)
        {
            _context.Departments.Remove(department);
            return _context.SaveChanges();

        }
    }
}
