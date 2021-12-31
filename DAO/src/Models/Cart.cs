using System.Collections.Generic;

namespace DAO.Models
{
    public class Cart
    {
        public long Id { get; set; }
        public List<ProductLine> CartLines { get; set; }
    }
}