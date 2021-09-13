namespace TecBankBackend.Models
{

    public class Client
    {
        public string id { get; set; }
        public string ssn { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string income { get; set; }
        public string clientType { get; set; }
        public string token { get; set; }
    }
}