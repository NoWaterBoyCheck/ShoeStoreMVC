using System;
using System.Collections.Generic;

namespace ShoeStoreDomain.Model;

public partial class Payment : Entity
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public decimal Amount { get; set; }

    public virtual Order Order { get; set; } = null!;
}
