using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace GUI_ELECTRIC
{
    class PhoneValidation : Validation
    {

        private String phone;
        private Regex regex = new Regex(@"^0\d{9,10}$");

        public PhoneValidation(string phone)
        {
            this.phone = phone;
        }

        public bool validate()
        {
            return regex.IsMatch(phone);
        }
    }
}
