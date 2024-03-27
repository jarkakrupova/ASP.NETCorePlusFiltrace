using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Core_11_23.Models {
    public class Student {
        private string fullName;
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [NotMapped]
        public string FullName { get => $"{FirstName} {LastName}"; }
    }

}
