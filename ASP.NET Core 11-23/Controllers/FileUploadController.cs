using ASP.NET_Core_11_23.DTO;
using ASP.NET_Core_11_23.Models;
using ASP.NET_Core_11_23.Services;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Xml;

namespace ASP.NET_Core_11_23.Controllers {
    public class FileUploadController : Controller {
        private StudentService studentService;

        public FileUploadController(StudentService studentService) {
            this.studentService = studentService;
        }

        public IActionResult Index() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file) {
            string filePath = "";
            if (file.Length > 0) {
                filePath = Path.GetFullPath(file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create)) {
                    await file.CopyToAsync(stream);
                    stream.Close();
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(filePath);
                    XmlElement koren = xmlDoc.DocumentElement;
                    foreach (XmlNode node in koren.SelectNodes("/Students/Student")) {
                        StudentDTO s = new StudentDTO {
                            FirstName = node.ChildNodes[0].InnerText,
                            LastName = node.ChildNodes[1].InnerText,
                            DateOfBirth = DateTime.Parse(node.ChildNodes[2].InnerText, CultureInfo.CreateSpecificCulture("cs-CZ"))
                        };
                        await studentService.CreateAsync(s);
                    }
                }
                return RedirectToAction("Index", "Students");
            }
            else return View("NotFound");

        }
    }
}
