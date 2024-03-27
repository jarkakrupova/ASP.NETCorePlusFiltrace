using ASP.NET_Core_11_23.Models;
using ASP.NET_Core_11_23.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_11_23.Controllers.API
{
    [Route("api/subjects")]
    [ApiController]
    public class SubjectsApiController : ControllerBase
    {
        public SubjectService _service;
        public SubjectsApiController(SubjectService service)
        {
            this._service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subject>>> IndexAsync()
        {
            var allSubjects = await _service.GetAllAsync();
            return Ok(allSubjects);
        }
        //public IActionResult Create()
        //{
        //    return View();
        //}
        [HttpPost]
        public async Task<IActionResult> Create(Subject newSubject)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateAsync(newSubject);
                return RedirectToAction("Index");
            }
            else
            {
                return Ok(newSubject);
            }
        }
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var subjectToEdit = await _service.GetByIdAsync(id);
        //    if (subjectToEdit == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(subjectToEdit);
        //}
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, Subject subject)
        {
            await _service.UpdateAsync(id, subject);
            return Ok(subject);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var subjectToDelete = await _service.GetByIdAsync(id);
            if (subjectToDelete == null)
            {
                return NotFound();
            }
            await _service.DeleteAsync(id);
            return Ok();
        }
    }
}

