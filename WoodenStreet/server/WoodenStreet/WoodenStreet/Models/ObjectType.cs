﻿using System;
using System.Collections.Generic;

namespace WoodenStreet.Models;

public partial class ObjectType
{
    public int ObjectTypeId { get; set; }

    public string ObjectTypeName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<Object> Objects { get; } = new List<Object>();
}
