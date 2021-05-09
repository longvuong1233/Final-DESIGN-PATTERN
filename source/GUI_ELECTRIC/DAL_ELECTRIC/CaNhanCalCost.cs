using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ELECTRIC;
namespace DAL_ELECTRIC
{
    class CaNhanCalCost : CalCostMethod
    {
       
        public CaNhanCalCost(int customerID,float cost,string unit) : base(customerID, cost,unit)
        {
            
        }

        protected override float calCost(float counter)
        {

            if (counter < 50)
            {
                return counter * Cost;
            }else if (counter < 100)
            {
                return counter * Cost * (1 + 0.0329f);
            }
            else
            {
                return counter * Cost * (1 + 0.1613f);
            }
            


        }
    }
}
