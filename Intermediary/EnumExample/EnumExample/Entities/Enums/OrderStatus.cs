using System;
using System.Collections.Generic;
using System.Text;

namespace EnumExample.Entities.Enums
{
    enum OrderStatus : int
    {
        //indica automaticamente que inicia com zero
        PendingPayment, 
        Processing,
        Shipped,
        Delivered
    }
}
