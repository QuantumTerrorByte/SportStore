namespace DAO.Models
{
    public class Address
    {
        public long Id { get; set; }
        
        public string PostalOffice { get; set; }
        public string City { get; set; }
        public string House { get; set; }
        public string Street { get; set; }
        public string Apartment { get; set; }
    }
}