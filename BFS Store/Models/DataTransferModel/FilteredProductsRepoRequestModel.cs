namespace SportStore.Models.DataTransferModel
{
    public class FilteredProductsRepoRequestModel
    {
        public int MinPrice { get; set; } 
        public int MaxPrice { get; set; } 
        public string Category1 { get; set; } 
        public string Category2 { get; set; } 
        public string Brand { get; set; }
        public string Sort { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 24;
        public bool AttachInfo { get; set; } = false;
    }
}