using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_11_23.Models {
    public class Subject {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "The name should not be longer than 20 characters")]
        public string Name { get; set; }
    }

}
