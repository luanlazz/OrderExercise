﻿using System;
namespace OrderProject.Entities.Enum
{
    public enum OrderStatus: int
    {
        Pending_payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
