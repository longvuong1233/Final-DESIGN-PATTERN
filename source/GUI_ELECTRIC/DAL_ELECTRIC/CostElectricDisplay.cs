using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_ELECTRIC
{
    public class CostElectricDisplay : Observer, DisplayElement
    {
        private Subject CostData;
        private float cost;
        private float costPay;
        private Label lbCost;
        private string unit;
        private Label lbPay;
      

        public CostElectricDisplay(Subject costData, float cost, float costPay,int idCustomer, Label lbCost, Label lbPay) :base(idCustomer)
        {
            CostData = costData;
            this.cost = cost;
            this.costPay = costPay;
            this.lbCost = lbCost;
            this.lbPay = lbPay;
           
            
            costData.registerObserver(this);
        }

        public void display()
        {
            lbCost.Text = "Giá tiền điện/Wh: " + cost;
            lbPay.Text = "Giá tiền phải trả: " + costPay;
        }

        public override void update(float cost,string unit, float costPay)
        {
            this.cost = cost;
            this.costPay = costPay;
            this.unit = unit;
            display();
        }
    }

}
