﻿using System;
using System.Collections.Generic;

namespace ShoeStoreDomain.Model;

public partial class Review : Entity
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public int Rating { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
