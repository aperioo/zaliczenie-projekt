using Common;
using System;

namespace ABC.bl
{
    public class Product : BaseClass, ILogging
    {

        public Product()
        {

        }
        public Product(int ProductID)
        {
            this.ProductID = ProductID;
        }
        public int ProductID { get; private set; }
        public Decimal? OrderPrice { get; set; }
        public string Description { get; set; }
        private string _ProductName;

        public string ProductName
        {
            get {
                return _ProductName.InsertSpace(); }
            set { _ProductName = value; }
        }

        public override bool Validate()
        {
            var correct = true;
            if (string.IsNullOrWhiteSpace(ProductName))
                correct = false;

            return correct;
        }
        public override string ToString()
        {
            return ProductName;
        }
        public string Log()
        {
            var logtext = ProductID + ": " +
                    ProductName + " " +
                    "Opis: " + Description + " " +
                    "Status: " + ObjectStatus.ToString();
            return logtext;
        }

    }
}
