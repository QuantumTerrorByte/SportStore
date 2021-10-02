namespace SportStore.Models
{
    public class ProductInfo
    {
        public long Id { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        
        
        public string Recommendations { get; set; }
        public string Ingredients { get; set; }
        public string Warning { get; set; }
        
        public override string ToString()
        {
            return $"T_T";
        }
    }
}