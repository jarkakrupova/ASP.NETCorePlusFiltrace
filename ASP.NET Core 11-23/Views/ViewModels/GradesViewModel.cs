using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace ASP.NET_Core_11_23.Views.ViewModels {
    public class GradesViewModel {
        public int Id { get; set; }
        //[DisplayName("Student Name")]
        //public int StudentId { get; set; }
        //[DisplayName("Subject Name")]
        //public int SubjectId { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public string What { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
    }

}
