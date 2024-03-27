using ASP.NET_Core_11_23.DTO;
using ASP.NET_Core_11_23.Services;
using ASP.NET_Core_11_23.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.NET_Core_11_23.Controllers
{
    public class GradesController : Controller {
        private GradesService service;

        public GradesController(GradesService service) {
            this.service = service;
        }

        public async Task<IActionResult> Index() {
            var allGrades = await service.GetAllAsync();
            return View(allGrades);
        }
        public async Task<IActionResult> Create() {
            var gradesDropdownsData = await service.GetNewGradesDropdownsValues();
            ViewBag.Students = new SelectList(gradesDropdownsData.Students, "Id", "FullName");
            ViewBag.Subjects = new SelectList(gradesDropdownsData.Subjects, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(GradeDTO newGrade) {
            if (!ModelState.IsValid) {
                var gradesDropdownsData = await service.GetNewGradesDropdownsValues();
                ViewBag.Students = new SelectList(gradesDropdownsData.Students, "Id", "LastName");
                ViewBag.Subjects = new SelectList(gradesDropdownsData.Subjects, "Id", "Name");
                return View(newGrade);
            }
            await service.CreateAsync(newGrade);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id) {
            var gradeToEdit = await service.GetByIdAsync(id);
            if (gradeToEdit == null) {
                return View("NotFound");
            }
            var response = new GradeDTO() {
                Id = gradeToEdit.Id,
                Date = gradeToEdit.Date,
                Mark = gradeToEdit.Mark,
                StudentId = gradeToEdit.Student.Id,
                SubjectId = gradeToEdit.Subject.Id,
                Topic = gradeToEdit.Topic
            };
            var gradesDropdownsData = await service.GetNewGradesDropdownsValues();
            ViewBag.Students = new SelectList(gradesDropdownsData.Students, "Id", "LastName");
            ViewBag.Subjects = new SelectList(gradesDropdownsData.Subjects, "Id", "Name");
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, GradeDTO updatedGrade) {
            await service.UpdateAsync(id, updatedGrade);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteAsync(int id) {
            await service.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
