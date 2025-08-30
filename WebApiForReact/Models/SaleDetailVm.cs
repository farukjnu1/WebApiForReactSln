namespace WebApiForReact.Models
{
    public class SaleDetailVm
    {
        public int SaleDetailId { get; set; }

        public int? Quantity { get; set; }

        public int? UnitPrice { get; set; }

        public string? Particular { get; set; }

        public int? TotalPrice { get; set; }

        public int? SaleId { get; set; }
        public IFormFile? File { get; set; }
    }
}
