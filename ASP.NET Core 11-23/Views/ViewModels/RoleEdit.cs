using ASP.NET_Core_11_23.Models;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core_11_23.Views.ViewModels {
    public class RoleEdit {
        public IdentityRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }

    }
}
