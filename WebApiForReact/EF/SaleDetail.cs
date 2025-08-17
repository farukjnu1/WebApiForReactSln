using System;
using System.Collections.Generic;

namespace WebApiForReact.EF;

public partial class SaleDetail
{
    public int SaleDetailId { get; set; }

    public int? Quantity { get; set; }

    public int? UnitPrice { get; set; }

    public string? Particular { get; set; }

    public int? TotalPrice { get; set; }

    public int? SaleId { get; set; }
}
