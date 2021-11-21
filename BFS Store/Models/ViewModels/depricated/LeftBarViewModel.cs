using System.Collections.Generic;

namespace SportStore.Models.ViewModels.depricated
{
    public class LeftBarViewModel
    {
        public IEnumerable<string> Categories { get; set; }
        public string CurrentCategory { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
    }
}