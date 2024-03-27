namespace ASP.NET_Core_11_23.Views.ViewModels {
    public class RoleModification {
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[]? AddIds { get; set; }
        public string[]? DeleteIds { get; set; }

    }
}
