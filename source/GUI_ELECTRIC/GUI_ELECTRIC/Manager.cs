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
using DAL_ELECTRIC;
namespace GUI_ELECTRIC
{
    public partial class Manager : Form
    {

       private  BUS_Customer busCustomer = new BUS_Customer();
        private BUS_Meter busMeter = new BUS_Meter();
        DAL_Electric_Company dalElectricCompany = DAL_Electric_Company.getElectricCompanyObserver();
        public Manager()
        {
            InitializeComponent();
        }

       

        private void assign_Click(object sender, EventArgs e)
        {
            Assign myAssign = new Assign();
            myAssign.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            customerGridView.DataSource = busCustomer.getCustomer();
            MeterGridView.DataSource = busMeter.getMeter();
            displayCustomer();
            displayMeter();
        }

        private void customerGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }
        private void displayCustomer()
        {
            DataGridViewRow row = customerGridView.CurrentRow;

            // Chuyển giá trị lên form
            inputName.Text = row.Cells[1].Value.ToString();
            inputPhone.Text = row.Cells[2].Value.ToString();
            inputAddress.Text = row.Cells[3].Value.ToString();
        }
        private void displayMeter()
        {
            DataGridViewRow row = MeterGridView.CurrentRow;
             
            if (row!=null)
            {
                // Chuyển giá trị lên form
                inputIDMeter.Text = row.Cells[0].Value.ToString();
                inputCounter.Text = row.Cells[1].Value.ToString();
            }
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customerGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            displayCustomer();
        }

        private void MeterGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            displayMeter();
        }

        private void newMeterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meter myMeter = new Meter();
            myMeter.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null)
            {
                String unit = comboBox5.SelectedItem.ToString();
                if (unit != "")
                {
                    
                    DTO_Electric_Company mycompany = DTO_Electric_Company.getElectricCompany();
                    dalElectricCompany.setData(mycompany.ELECTRIC_COST, unit);
                }
            }
        }
    }
}
