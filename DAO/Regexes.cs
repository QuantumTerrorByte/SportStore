using System.Text.RegularExpressions;

namespace DAO
{
    public class Regexes
    {
        public const string EmailRegex = @".+@.+\\..+";
        public const string PhoneRegex = @"^\+*\d{10}";
    }
}