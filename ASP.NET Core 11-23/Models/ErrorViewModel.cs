namespace ASP.NET_Core_11_23.Models {
    public class ErrorViewModel {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}