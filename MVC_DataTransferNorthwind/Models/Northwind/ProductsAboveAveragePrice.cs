﻿using System;
using System.Collections.Generic;

namespace MVC_DataTransferNorthwind.Models.Northwind;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
