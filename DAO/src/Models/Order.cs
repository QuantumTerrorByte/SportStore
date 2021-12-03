

namespace DAO.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Cart Cart { get; set; }
        public bool IsDone { get; set; }

        public AppUser Costumer { get; set; }
        public Address Address { get; set; }
        
        public bool GiftWrap { get; set; }
    }
}