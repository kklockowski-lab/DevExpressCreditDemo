using DataCreditGenerator.Heleprs;

namespace DataCreditGenerator.Model
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public Gender Gender { get; set; }
    }
}
