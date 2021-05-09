using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_ELECTRIC
{
    class DoanhNghiepCalCost: CalCostMethod
    {

        public DoanhNghiepCalCost(int customerID, float cost, string unit) : base(customerID, cost, unit)
        {

        }

        protected override float calCost(float counter)
        {

            
             if (counter < 100)
            {
                return counter * Cost ;
            }
            else
            {
                return counter * Cost * (1 + 0.0613f);
            }



        }
    }
}
