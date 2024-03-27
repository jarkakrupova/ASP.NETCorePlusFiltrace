using ASP.NET_Core_11_23.Models;
using ASP.NET_Core_11_23.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_11_23.Controllers {
    public class SubjectsController : Controller {
        public SubjectService _service;
        public SubjectsController(SubjectService service) {
            this._service = service;
        }

        public async Task<IActionResult> IndexAsync() {
            var allSubjects = await _service.GetAllAsync();
            return View(allSubjects);
        }
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Subject newSubject) {
            if (ModelState.IsValid) {
                await _service.CreateAsync(newSubject);
                return RedirectToAction("Index"); 
            }
            else {
                return View();
            }
        }
        public async Task<IActionResult> Edit(int id) {
            var subjectToEdit = await _service.GetByIdAsync(id);
            if (subjectToEdit == null) {
                return View("NotFound");
            }
            return View(subjectToEdit);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Subject Subject) {
            await _service.UpdateAsync(id, Subject);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id) {
            var subjectToDelete = await _service.GetByIdAsync(id);
            if (subjectToDelete == null) {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
