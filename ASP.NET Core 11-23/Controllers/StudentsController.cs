using ASP.NET_Core_11_23.DTO;
using ASP.NET_Core_11_23.Models;
using ASP.NET_Core_11_23.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_11_23.Controllers {
    public class StudentsController : Controller {
        public StudentService _service;
        public StudentsController(StudentService service) {
            this._service = service;
        }

        public async Task<IActionResult> IndexAsync() {
            var allStudents = await _service.GetAllAsync();
            return View(allStudents);
        }
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(StudentDTO newStudent) {
            await _service.CreateAsync(newStudent);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id) {
            var studentToEdit = await _service.GetByIdAsync(id);
            if (studentToEdit == null) {
                return View("NotFound");
            }
            return View(studentToEdit);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, StudentDTO student) {
            await _service.UpdateAsync(id, student);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id) {
            var studentToDelete = await _service.GetByIdAsync(id);
            if (studentToDelete == null) {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
