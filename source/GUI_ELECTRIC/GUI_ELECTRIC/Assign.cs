using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_ELECTRIC;
using DTO_ELECTRIC;
namespace GUI_ELECTRIC
{
    public partial class Assign : Form
    {
        private BUS_Customer busCustomer = new BUS_Customer();
        private BUS_Meter busMeter = new BUS_Meter();
        public Assign()
        {
            InitializeComponent();
        }

        private void Assign_Load(object sender, EventArgs e)
        {
            customerGridView.DataSource = busCustomer.getCustomer();
            meterGridView.DataSource = busMeter.getMeter();

            customerCb.DataSource = busCustomer.getCustomer();
            customerCb.DisplayMember = "_CUSTOMER_NAME";
            customerCb.ValueMember = "_CUSTOMER_ID";
            meterCb.DataSource = busMeter.getMeter();
            meterCb.DisplayMember = "_METER_ID";
            meterCb.ValueMember = "_METER_ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String idCustomer = customerCb.SelectedValue.ToString();
            String idMeter =meterCb.SelectedValue.ToString();
            Console.WriteLine(idCustomer + "!23");
            DTO_Customer myCustomer = busCustomer.findCustomer(int.Parse(idCustomer));
           
            myCustomer.METER_ID = int.Parse( idMeter);
            bool result = busCustomer.editCustomer(myCustomer);

            customerGridView.DataSource = busCustomer.getCustomer();

        }
    }
}
