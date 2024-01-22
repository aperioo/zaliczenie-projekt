using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.bl
{
    public class AdresRepository
    {
        public Adres Download(int AdresID)
        {
           Adres adres = new Adres(AdresID);

            if (AdresID == 1) 
            {
                adres.AdresType = 1;
                adres.Street = "Gościnna";
                adres.City = "Katowice";
                adres.Country = "Polska";
                adres.PostalCode = "51-165";
            }
            return adres;
        }
        public IEnumerable<Adres>DownloadByClientID(int ClientID) 
        {
            //kod
            //tymczasowe wartości
            var adresList = new List<Adres>();
            Adres adres = new Adres(1)
            {
                AdresType = 1,
                Street = "Gościnna",
                City = "Katowice",
                PostalCode = "51-164",
                Country = "Polska"
            };
            adresList.Add(adres);
            adres = new Adres(2)
            {
                AdresType = 1,
                Street = "Kosmiczna",
                City = "Kraków",
                PostalCode = "61-164",
                Country = "Polska"
            };
            adresList.Add(adres);
            return adresList;

        }
        public bool Save(Adres adres)
        {
            // kod zapisujacy
            return true;
        }
    }
}
