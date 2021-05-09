using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_ELECTRIC;

namespace DAL_ELECTRIC
{
    abstract class CalCostMethod
    {
        DTO_Customer customerTarget;
        int customerID;
        float cost;
        string unit;

        public DTO_Customer CustomerTarget { get => customerTarget; set => customerTarget = value; }
        public float Cost { get => cost; set => cost = value; }

        protected CalCostMethod(int customerID,float cost,string unit)
        {
            this.customerID = customerID;
            this.cost = cost;
            this.unit = unit;
        }

        protected  DTO_Customer getCustomer()
        {
            DAL_Customer dalCustomer = new DAL_Customer();
           
            return dalCustomer.findCustomer(customerID);
        }

        protected float getCounter()
        {
            DAL_Meter dalMeter = new DAL_Meter();
            
            DTO_Meter myMeter = dalMeter.findMeter(CustomerTarget.METER_ID);

            float counter = myMeter.Meter_Count;
       
            return counter;
        }

        protected abstract float calCost(float counter);
        protected float convert(float money)
        {
            if(unit== "Do La")
            {
                VietNamDongTarget vn = new ConvertAdapter(new DoLaAdaptee());
                return vn.convert(money);
            }
            return money;
        }
        public  float execute()
        {
            this.CustomerTarget = getCustomer();
            float pay = calCost(getCounter());
            return convert(pay);
        }
    }
}
