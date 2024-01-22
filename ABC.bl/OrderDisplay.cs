using System;
using System.Collections.Generic;

namespace ABC.bl
{
    public class OrderDisplay
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderStatusDisplay> OrderStatusDisplayList { get; set; }
        public int OrderID { get; set; }
        public Adres OrderAdres { get; set; }


    }
}
