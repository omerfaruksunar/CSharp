﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Core.Dtos;

public partial class DtoCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; }

    public string Description { get; set; }

    public byte[] Picture { get; set; }

    public virtual ICollection<DtoProduct> Products { get; set; } = new List<DtoProduct>();
}