namespace ABC.bl
{
    public class Adres
    {
        public Adres()
        {   
        }
        public Adres(int AdresID)
        {
            this.AdresID = AdresID;
        }
        public int AdresID { get; private set;}
        public int AdresType { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

    }
}
