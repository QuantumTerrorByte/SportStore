using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAO.Models.Core;

namespace DAO.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<CartLine> CartLines { get; set; }
        public bool IsDone { get; set; }

        public AppUser Costumer { get; set; }
        public Address Address { get; set; }
        
        public bool GiftWrap { get; set; }
    }
}