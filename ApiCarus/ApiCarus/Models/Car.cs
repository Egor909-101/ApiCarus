using System;
using System.Collections.Generic;

namespace ApiCarus.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public int? Mileage { get; set; }

    public decimal Price { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
}
