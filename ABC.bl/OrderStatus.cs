namespace ABC.bl
{
    public class OrderStatus
    {
        public OrderStatus()
        {
            
        }
        public OrderStatus(int OrderStatusID)
        {
            this.OrderStatusID = OrderStatusID;
        }
        public int OrderStatusID { get; private set;}
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public decimal? PurchaseValue { get; set; }

        public OrderStatus Download(int ProductID)
        {
            return new OrderStatus();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var correct = true;
            if (Quantity <= 0)
                correct = false;
            if (ProductID <= 0)
                correct = false;
            if (PurchaseValue == null)
                correct = false;
            return correct;
        }
    }
}
