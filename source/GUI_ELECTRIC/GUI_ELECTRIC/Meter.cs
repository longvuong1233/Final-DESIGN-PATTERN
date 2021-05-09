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
    public partial class Meter : Form
    {
        private BUS_Meter busMeter = new BUS_Meter();
        public Meter()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Meter_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            meterGridView.DataSource = busMeter.getMeter();
        }

        private void meterGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO_Meter newMeter = new DTO_Meter(0);
            bool result = busMeter.addMeter(newMeter);
            if (result == true)
            {
                meterGridView.DataSource = busMeter.getMeter();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = meterGridView.CurrentRow;
            if (row != null)
            {
                // Chuyển giá trị lên form
                int idMeter = int.Parse(row.Cells[0].Value.ToString());
                bool result = busMeter.deleteMeter(idMeter);
                if (result == true)
                {
                    meterGridView.DataSource = busMeter.getMeter();
                }

            }
        }
    }
}
