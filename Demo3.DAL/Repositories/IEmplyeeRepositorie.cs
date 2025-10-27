using Demo3.DAL.Models.DepartmentModels;
using Demo3.DAL.Models.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo3.DAL.Repositories
{
    public interface IEmplyeeRepositorie
    {
        IEnumerable<Employee> GetAll(bool withTracking = false);
        public IEnumerable<Employee> GetAll(Expression<Func<Employee, bool>> predicate);
        Employee? GetById(int id);
        int Add(Employee employee);
        int Update(Employee employee);
        public int Remove(Employee employee);
    }
}
