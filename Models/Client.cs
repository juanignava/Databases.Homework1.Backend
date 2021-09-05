namespace TecBankBackend.Models
{
    public class Name
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }

        public Name(string FirstName, string SecondName, string LastName1, string LastName2)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName1 = LastName1;
            this.LastName2 = LastName2;
        }
    }

    public class Adress
    {
        public string Province { get; set; }
        public string Canton { get; set;}
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string AditionalDescription { get; set; }

        public Adress(string Province, string Canton, string District, string Neighborhood, string AditionalDescription)
        {
            this.Province = Province;
            this. Canton = Canton;
            this.District = District;
            this.Neighborhood = Neighborhood;
            this.AditionalDescription = AditionalDescription;
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ClientType { get; set; }
        public int MonthlyIncome { get; set; }
        public Name Name { get; set; }
        public Adress Adress { get; set; }
    }
}