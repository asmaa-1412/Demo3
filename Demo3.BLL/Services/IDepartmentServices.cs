using Demo3.BLL.DTOs;

namespace Demo3.BLL.Services
{
    public interface IDepartmentServices
    {
        IEnumerable<DepartmentDto> GetAllDepartments();
        DepartmentDetailsDto? GetById(int id);
        public int AddDepartment(CreatedDepartmentDto dept);
        public int UpdateDepartment(UpdateDepartmentDto dto);
        public bool DeleteDepartment(int id);
    }
}