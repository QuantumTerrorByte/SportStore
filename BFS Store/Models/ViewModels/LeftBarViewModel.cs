using System.Collections.Generic;

namespace SportStore.Models.ViewModels
{
    public class LeftBarViewModel
    {
        public IEnumerable<string> Categories { get; set; }
        public string CurrentCategory { get; set; }
    }
}