using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Services;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {       
        public async Task<IActionResult> Index()
        {
            var departmentService = new DepartmentService();
            var departments = await departmentService.GetAll();
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Department department)
        {
            var departmentService = new DepartmentService();
            await departmentService.CreateAsync(department);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DetailsAsync(int id)
        {
            var departmentService = new DepartmentService();
            var department = await departmentService.GetById(id);

            return View(department);
        }

        public async Task<IActionResult> UpdateAsync(int id)
        {
            var departmentService = new DepartmentService();
            var department = await departmentService.GetById(id);

            return View(department);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAsync(Department department)
        {
            var departmentService = new DepartmentService();
            await departmentService.UpdateAsync(department);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAsync(int id)
        {
            var departmentService = new DepartmentService();
            var department = await departmentService.GetById(id);

            return View(department);
        }

        public async Task<IActionResult> DeleteDepartmentAsync(int id)
        {
            var departmentService = new DepartmentService();
            await departmentService.DeleteAsync(id);

            return RedirectToAction("Index");
        }
    }
}
