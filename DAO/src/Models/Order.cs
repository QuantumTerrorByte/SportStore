

using System;
using System.ComponentModel.DataAnnotations;

namespace DAO.Models
{
    public class Order
    {
        public long Id { get; set; }
        public long CartId { get; set; }
        public Cart Cart { get; set; } 
        public Statusess OrderStatus { get; set; }  

        public string CostumerId { get; set; }
        public AppUser Costumer { get; set; }
        [StringLength(200)]
        public string Comment { get; set; }
        
        public DateTime DateTime { get; set; }
        public bool GiftWrap { get; set; }
    }
}