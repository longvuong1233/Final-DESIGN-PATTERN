using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_ELECTRIC
{
    class KindCustomerValidation : Validation
    {
        private String kind;
        private String[] listKind= { "ca nhan", "doanh nghiep", "nha tro" };

        public KindCustomerValidation(string kind)
        {
            this.kind = kind;
        }

        public bool validate()
        {
            return Array.IndexOf(listKind, kind) != -1 ? true : false;
        }
    }
}
