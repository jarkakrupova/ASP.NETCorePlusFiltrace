using ASP.NET_Core_11_23.Models;

namespace ASP.NET_Core_11_23.Views.ViewModels {
    public class GradesDropdownsViewModel {
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public GradesDropdownsViewModel() {
            Students = new List<Student>();
            Subjects = new List<Subject>();
        }
    }

}
