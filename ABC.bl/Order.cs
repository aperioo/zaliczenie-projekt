using Common;
using System;
using System.Collections.Generic;

namespace ABC.bl
{
    public class Order : BaseClass, ILogging
    {
        public Order()
        {
            
        }
        public Order(int OrderID)
        {
            this.OrderID = OrderID;
        }
        public int OrderID { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderStatus> OrderPosition { get; set; }
        public int ClientID { get; set; }
        public int OrderAdresID { get; set; }

        //pobieramy jedno zamówienie
        public Order Download(int OrderID)
        {
            //pobieranie danego zamówienia
            return new Order();
        }

        //zapisywanie zamówienia
        public bool Save()
        {
            // kod
            return true;
        }
        //Sprawdzamy dane zamówienia
        public override bool Validate()
        {
            var correct = true;
            if (OrderDate == null)
                correct = false;

            return correct;
        }
        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderID + ")";
        }

        public string Log()
        {
            var logText = OrderID + ": " +
                           "Data: " + OrderDate.Value.Date + " " + 
                           "Status: " + ObjectStatus.ToString();
            return logText;
        }
    }
}
