using System.Collections.Generic;
using System.Linq;

namespace ABC.bl
{
    public class ClientRepository
    {
        private AdresRepository adresRepository {  get; set; }
        public ClientRepository()
        {
            adresRepository = new AdresRepository();
        }
        public Client Download(int ClientID)
        {
            Client client = new Client(ClientID);
            client.AdresList = adresRepository.DownloadByClientID(ClientID).ToList();
            //kod, który pobiera klienta

            //tymczasowe gówno do sprawdzenia czy działa
            if (ClientID == 1)
            {
                client.EmailAdress = "izraelnieistnieje@gmail.com";
                client.Firstname = "Jonasz";
                client.Lastname = "Mekka";
            }
            return client;
        }
        public List<Client> Download()
        {
            //kod pobiera wszystkich klientów
            return new List<Client>();
        }
        public bool Save(Client client)
        {
            var success = true;
            if (client.IsChanged && client.IsDataCorrect)
            {
                if (client.IsNew)
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
