using System;
using System.Collections.Generic;

namespace ApiCarus.Models;

public partial class Purchase
{
    public int PurchaseId { get; set; }

    public int BuyerId { get; set; }

    public int CarId { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public decimal Price { get; set; }

    public virtual User Buyer { get; set; } = null!;

    public virtual Car Car { get; set; } = null!;
}
