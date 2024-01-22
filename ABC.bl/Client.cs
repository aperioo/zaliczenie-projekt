using Common;
using System.Collections.Generic;

namespace ABC.bl
{
    public class Client : BaseClass, ILogging
    {
        public Client() : this(0)
        {

        }
        public Client(int ClientID)
        {
            this.ClientID = ClientID;
            AdresList = new List<Adres>();
        }
        public List<Adres> AdresList { get; set; }
        public static int Counter { get; set; }

        private string _lastname;
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
        public string Firstname { get; set; }
        public string EmailAdress { get; set; }
        public int ClientID { get; private set; }
        public string FirstnameLastname
        {
            get
            {
                string firstnamelastname = Firstname;
                if (!string.IsNullOrWhiteSpace(Lastname))
                    {
                    if(!string.IsNullOrWhiteSpace(firstnamelastname))
                    { 
                    firstnamelastname += " ";
                    }
                    firstnamelastname += Lastname;
                    }
                  
                return firstnamelastname;
            }

        }
        public int ClientType { get; set; }

        public override bool Validate()
        {
            var correct = true;
            if (string.IsNullOrWhiteSpace(Lastname))
                correct = false;
            if (string.IsNullOrWhiteSpace(EmailAdress))
                correct = false;
            
            return correct;
        }
        public bool Save()
        {
            //kod zapisujacy
            return true;
        }
        public Client Download(int ClientID) 
        {
            //kod pobierający danego klienta
            return new Client();
        }
        public List<Client> Download()
        {
            //kod pobiera wszystkich klientów
            return  new List<Client>();
        }
        public override string ToString()
        {
            return FirstnameLastname;
        }
        public string Log()
        {
            var logtext =ClientID + ": " +
                    FirstnameLastname + " " +
                    "Email: " + EmailAdress + " " +
                    "Status: " + ObjectStatus.ToString();
            return logtext;
        }
    }
}
 