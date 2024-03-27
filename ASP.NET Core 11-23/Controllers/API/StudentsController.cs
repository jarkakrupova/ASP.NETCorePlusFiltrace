using ASP.NET_Core_11_23.DTO;
using ASP.NET_Core_11_23.Models;
using ASP.NET_Core_11_23.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_11_23.Controllers.API
{
    [Route("api/students")]
    [ApiController]
    public class StudentsApiController : ControllerBase
    {
        public StudentService _service;
        public StudentsApiController(StudentService service)
        {
            this._service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> IndexAsync()
        {
            var allStudents = await _service.GetAllAsync();
            return Ok(allStudents);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var student = await _service.GetByIdAsync(id);
            return Ok(student);
        }
        //public IActionResult Create()
        //{
        //    return View();
        //}
        [HttpPost]
        public async Task<IActionResult> Create(StudentDTO newStudent)
        {
            await _service.CreateAsync(newStudent);
            return Ok(newStudent);
            //return RedirectToAction("Index");
        }
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var studentToEdit = await _service.GetByIdAsync(id);
        //    if (studentToEdit == null)
        //    {
        //        return View("NotFound");
        //    }
        //    return View(studentToEdit);
        //}
        [HttpPut("{id}")]
        public async Task<ActionResult> Edit(int id, StudentDTO student)
        {
            await _service.UpdateAsync(id, student);
            return Ok(student);
            //return RedirectToAction("Index");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var studentToDelete = await _service.GetByIdAsync(id);
            if (studentToDelete == null)
            {
                return NotFound();
            }
            await _service.DeleteAsync(id);
            return Ok();
            //return RedirectToAction("Index");
        }
    }
}
