using Demo3.DAL.Models;

namespace Demo3.DAL.Repositories
{
    public interface IDepartmentRepositorie
    {
        IEnumerable<Department> GetAll(bool withTracking = false);
        Department? GetById(int id);
        int Add(Department department);
        int Update(Department department);
        public int Remove(Department department);
       
    }
}