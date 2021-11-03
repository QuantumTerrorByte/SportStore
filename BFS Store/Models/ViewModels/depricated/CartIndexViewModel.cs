using System.Runtime.Serialization;
using SportStore.Models.Core;

namespace SportStore.Models.ViewModels
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}