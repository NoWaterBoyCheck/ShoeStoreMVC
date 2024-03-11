using System;
using System.Collections.Generic;

namespace ShoeStoreDomain.Model;

public partial class Brand : Entity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
