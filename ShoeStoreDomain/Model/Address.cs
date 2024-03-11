using System;
using System.Collections.Generic;

namespace ShoeStoreDomain.Model;

public partial class Address : Entity
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string AddressLine { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Country { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
