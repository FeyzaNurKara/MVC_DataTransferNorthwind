﻿using System;
using System.Collections.Generic;

namespace MVC_DataTransferNorthwind.Models.Northwind;

public partial class SalesTotalsByAmount
{
    public decimal? SaleAmount { get; set; }

    public int OrderId { get; set; }

    public string CompanyName { get; set; } = null!;

    public DateTime? ShippedDate { get; set; }
}
