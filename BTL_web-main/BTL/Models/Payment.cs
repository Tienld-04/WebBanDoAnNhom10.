﻿using System;
using System.Collections.Generic;

namespace BTL.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string? Name { get; set; }

    public string? CardNo { get; set; }

    public string? ExpiryDate { get; set; }

    public int? CvvNo { get; set; }

    public string? Address { get; set; }

    public string? PaymentMode { get; set; }

    public decimal? ToTalBill { get; set; }

    public int? UserId { get; set; }
}
