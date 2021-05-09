using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_ELECTRIC
{
    class CalCostFactory
    {
        private CalCostFactory()
        {

        }

        public static CalCostMethod getCalCostMethod(String kind,int idCustomer, float cost,String unit)
        {
            switch (kind)
            {
                case "ca nhan":
                    {
                        return new CaNhanCalCost(idCustomer, cost,unit);
                        break;
                    }
                case "doanh nghiep":
                    {
                        return new DoanhNghiepCalCost(idCustomer, cost,unit);
                        break;
                    }
                case "nha tro":
                    {
                        return new NhaTroCalCost(idCustomer, cost,unit);
                        break;
                    }
                default:
                    {
                        return new CaNhanCalCost(idCustomer, cost,unit); 
                    }
            }
        }
    }
}
