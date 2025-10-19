using Microsoft.AspNetCore.Mvc;
using Demo3.BLL.Services;
using Demo3.BLL.DTOs.EmployeeDtos;
using Demo3.DAL.Models.DepartmentModels;
using Demo3.BLL.DTOs.DepartmentDtos;
namespace Demo3.PL.Controllers
{
    public class EmployeeController(IEmployeeServices _employeeServices) : Controller
    {
        public IActionResult Index()
        {
            var res=_employeeServices.GetAllEmployees();
            return View(res);
        }
        [HttpGet]
        public IActionResult Add([FromServices]IDepartmentServices _departmentServices)
        {
            ViewData["Department"] = _departmentServices.GetAllDepartments();
            return View();
        }
        [HttpPost]
        public IActionResult Add(CreatedEmployeeDto dto)
        {
            if (ModelState.IsValid)
            {
                int res = _employeeServices.AddEmployee(dto);
                if (res > 0) return View(nameof(Index));
                else return View(dto);
            }
            else return View(dto);
        }
        public IActionResult Delails(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var emp = _employeeServices.GetById(id.Value);
            if (emp is null) return NotFound();
            return View(emp);
        }
        [HttpGet]
        public IActionResult Edit(int? id, [FromServices] IDepartmentServices _departmentServices)
        {
            ViewData["Department"] = _departmentServices.GetAllDepartments();
            if (!id.HasValue) return BadRequest();
            var emp = _employeeServices.GetById(id.Value);
            if (emp is null) return NotFound();
            return View(emp);
        }
        [HttpPost]
        public IActionResult Edit(UpdatedEmployeeDto dto)
        {
            if (ModelState.IsValid)
            {
                int res = _employeeServices.UpdateEmployee(dto);
                if (res > 0) return View(nameof(Index));
                else return View(dto);
            }
            else return View(dto);
        }
    }
}
