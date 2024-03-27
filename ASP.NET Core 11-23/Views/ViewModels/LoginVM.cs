using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_11_23.Views.ViewModels {
    public class LoginVM {
        //[Required]
        public string UserName { get; set; }

        //[Required]
        public string Password { get; set; }

        public string? ReturnUrl { get; set; }
        public bool Remember { get; set; }
    }

}
