using System.Collections.Generic;

namespace DAO.Models.DataTransferModel
{
    public class OrderIndexViewModel
    {
        public PagingInfo PagingInfo { get; set; }
        public List<Order> Orders { get; set; }
    }
}