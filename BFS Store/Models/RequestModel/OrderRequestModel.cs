using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using DAO;
using DAO.Models;
using SportStore.Models.ViewModels;

namespace SportStore.Models.RequestModel
{
    public class OrderRequestModel
    {
        public long Id { get; set; }

        [Required, StringLength(25, MinimumLength = 5), RegexStringValidator(Regexes.EmailRegex)]
        public string Email { get; set; }
        [Required, StringLength(13, MinimumLength = 10), RegexStringValidator(Regexes.PhoneRegex)]
        public string Phone { get; set; }
        [Required, StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required, StringLength(30, MinimumLength = 2)]
        public string SecondName { get; set; }
        [Required, StringLength(30, MinimumLength = 2)]
        public string Patronymic { get; set; }
        
        public Address Address { get; set; }
        public string Comment { get; set; }

        public List<ProductLineViewModel> CartLines { get; set; }
        public bool GiftWrap { get; set; } //todo remove
    }

}