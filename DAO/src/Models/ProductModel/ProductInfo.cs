using System.Collections.Generic;

namespace DAO.Models.ProductModel
{
    public class ProductInfo
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public Langs Lang { get; set; }
        public Description ShortDescription { get; set; }
        public List<Description> DescriptionsLi { get; set; } //todo rename
        public List<Description> DopDescriptions { get; set; }
        public List<ProductIngredientsTableRow> Table { get; set; }
    }
}