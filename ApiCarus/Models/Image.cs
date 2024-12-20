using System;
using System.Collections.Generic;

namespace ApiCarus.Models;

public partial class Image
{
    public int ImageId { get; set; }

    public int CarId { get; set; }

    public string ImageUrl { get; set; } = null!;

    public bool? IsMainImage { get; set; }

    public virtual Car Car { get; set; } = null!;
}
