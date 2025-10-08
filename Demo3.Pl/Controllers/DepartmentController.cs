using Demo3.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Demo3.BLL.Services;
using Demo3.BLL.DTOs;

namespace Demo3.PL.Controllers
{
    public class DepartmentController(IDepartmentServices _department) : Controller
    {
        public IActionResult Index()
        {
            var departments = _department.GetAllDepartments();
            return View(departments);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatedDepartmentDto dto)
        {
            if (ModelState.IsValid)
            {
                    int res = _department.AddDepartment(dto);
                    if (res > 0) return View(nameof(Index));
                    else return View(dto);
            }
            else return View(dto);
        }
        public IActionResult Delails(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var dept = _department.GetById(id.Value);
            if (dept is null) return NotFound();
            return View(dept);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (!id.HasValue) return BadRequest();
            var dept = _department.GetById(id.Value);
            if (dept is null) return NotFound();
            return View(dept);
        }
        [HttpPost]
        public IActionResult Edit(UpdateDepartmentDto dto)
        {
            if (ModelState.IsValid)
            {
                int res = _department.UpdateDepartment(dto);
                if (res > 0) return View(nameof(Index));
                else return View(dto);
            }
            else return View(dto);
        }
    }
}
