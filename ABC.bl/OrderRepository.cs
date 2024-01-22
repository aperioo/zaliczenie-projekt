using System;
using System.Collections.Generic;

namespace ABC.bl
{
    public class OrderRepository
    {
        public Order Download(int OrderID)
        {
            Order zamowienie = new Order(OrderID);

            if (OrderID == 3)
                zamowienie.OrderDate = new DateTimeOffset(2018, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            
            return zamowienie;
        }
        public OrderDisplay DownloadOrderDisplay(int OrderID)
        {
            OrderDisplay orderDisplay = new OrderDisplay();
            //kod pobierający określone dane
            //tymczasowe dane zakodowane na stałe
            if (OrderID == 10)
            {
                orderDisplay.Firstname = "Marcin";
                orderDisplay.Lastname = "Kwak";
                orderDisplay.OrderDate = new DateTimeOffset(2024,1,1,1,17,15,3, new TimeSpan(7,0,0));
                orderDisplay.OrderAdres = new Adres()
                {
                    AdresType = 1,
                    Street = "Kosmiczna",
                    City = "Glogau",
                    PostalCode = "40-452",
                    Country = "Poland"
                };
             }
            orderDisplay.OrderStatusDisplayList = new List<OrderStatusDisplay>();
            //kod który pobiera te elementy do wyświetlenia
            //tymczasowe sztywne dane do testu
            if (OrderID == 10) 
            {
                var orderStatusDisplay = new OrderStatusDisplay()
                {
                    ProductName = "Szczotka",
                    OrderQuantity = 4,
                    OrderPrice = 119.77M
                };
                orderDisplay.OrderStatusDisplayList.Add(orderStatusDisplay);
                orderStatusDisplay = new OrderStatusDisplay()
                {
                    ProductName = "Miotła",
                    OrderQuantity = 7,
                    OrderPrice = 249M
                };
                orderDisplay.OrderStatusDisplayList.Add(orderStatusDisplay);
            }
            return orderDisplay;
        }

        public bool Save(Order order)
        {
            var success = true;
            if (order.IsChanged && order.IsDataCorrect)
            {
                if (order.IsNew)
                {
                    //wywołujemy insert
                }
                else
                {
                    //wywołujemy update
                }
            }
            return success;
        }
    }
}
