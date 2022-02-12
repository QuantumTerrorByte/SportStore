using System.Collections.Generic;

namespace DAO.Models.DataTransferModel
{
    public class OrderIndexDto
    {
        public PagingInfo PagingInfo { get; set; }
        public List<Order> Orders { get; set; }
    }
}