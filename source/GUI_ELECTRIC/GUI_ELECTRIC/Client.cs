using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_ELECTRIC;
using BUS_ELECTRIC;
using DAL_ELECTRIC;

namespace GUI_ELECTRIC
{
    public partial class Client : Form
    {

        private ICommand Slot1ON;
        private ICommand Slot1OFF;
        private ICommand Slot2ON;
        private ICommand Slot2OFF;
        private ICommand Slot3ON;
        private ICommand Slot3OFF;
        private ICommand Slot4ON;
        private ICommand Slot4OFF;

        //Light
        private DTO_Light light;
        private ICommand LightON;
        private ICommand LightOFF;

        //TV
        private DTO_Tivi tv;
        private ICommand TVON;
        private ICommand TVOFF;

     

        //Fan
        private DTO_Fan fan;
        private ICommand FanOn;
        private ICommand FanOFF;

        //DIEUHOA
        private DTO_DIEUHOA dieuhoa;
        private ICommand DIEUHOAOn;
        private ICommand DIEUHOAOff;
        DAL_Electric_Company dalElectricCompany = DAL_Electric_Company.getElectricCompanyObserver();
        BUS_Customer busCustomer = new BUS_Customer();
        BUS_Meter busmeter = new BUS_Meter();
        private int idMeter;
        

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {


            DTO_Customer myCustomer = busCustomer.findByPhone(Program.phoneClient);
            this.idMeter = myCustomer.METER_ID;

            //Light
            light =(DTO_Light)   BUS_Device.createDevice(DAL_Factory_Device.TypeDevice.LIGHT,button1,myCustomer.METER_ID) ;
            LightON = new DTO_Light_On(light);
            LightOFF = new DTO_Light_Off(light);

            //TV
            tv = (DTO_Tivi)BUS_Device.createDevice(DAL_Factory_Device.TypeDevice.TIVI, button2, myCustomer.METER_ID);
            TVON = new DTO_Tivi_On(tv);
            TVOFF = new DTO_Tivi_Off(tv);

           
            //Fan
            fan = (DTO_Fan)BUS_Device.createDevice(DAL_Factory_Device.TypeDevice.FAN, button5, myCustomer.METER_ID);
            FanOn = new DTO_Fan_On(fan);
            FanOFF = new DTO_Fan_Off(fan);

           // Dieuhoa
            dieuhoa = (DTO_DIEUHOA)BUS_Device.createDevice(DAL_Factory_Device.TypeDevice.DIEUHOA, button4, myCustomer.METER_ID);
            DIEUHOAOn = new DTO_DIEUHOA_On(dieuhoa);
            DIEUHOAOff = new DTO_DIEUHOA_Off(dieuhoa);


            //Observer


            CostElectricDisplay costDisplay = new CostElectricDisplay(dalElectricCompany, 0, 0,myCustomer.CUSTOMER_ID, lbCost, lbPay);
            
            //
            lbPhone.Text = Program.phoneClient;
            lbAddress.Text = myCustomer.CUSTOMER_ADDRESS;
            lbIdMeter.Text = myCustomer.METER_ID.ToString();
            lbName.Text = myCustomer.CUSTOMER_NAME;
            lbID.Text = myCustomer.CUSTOMER_ID.ToString();
            updateCouter();
        }

        private void listDevice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deviceCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String option = comboBox1.SelectedItem.ToString();
            choiceDevice(option, 1);
        }
        private void choiceDevice(String option, int slotNum)
        {
            if (slotNum == 1)
            {
                assignCommandOnOFF(option, ref Slot1ON, ref Slot1OFF);
            }
            else if (slotNum == 2)
            {
                assignCommandOnOFF(option, ref Slot2ON, ref Slot2OFF);
            }
            else if (slotNum == 3)
            {
                assignCommandOnOFF(option, ref Slot3ON, ref Slot3OFF);
            }
            else if (slotNum == 4)
            {
                assignCommandOnOFF(option, ref Slot4ON, ref Slot4OFF);
            }

        }

        private void assignCommandOnOFF(String option, ref ICommand On, ref ICommand Off)
        {
            if (option.Equals("LIGHT"))
            {
                Off = LightOFF;
                On = LightON;
            }
            else if (option.Equals("TIVI"))
            {
                Off = TVOFF;
                On = TVON;
            }
          
            else if (option.Equals("FAN"))
            {
                Off = FanOFF;
                On = FanOn;
            }
            else if (option.Equals("Điều Hòa"))
            {
                Off = DIEUHOAOff;
                On = DIEUHOAOn;
            }
            else if (option.Equals("None"))
            {
                Off = null;
                On = null;
            }
            //...
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String option = comboBox2.SelectedItem.ToString();
            choiceDevice(option, 2);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            String option = comboBox3.SelectedItem.ToString();
            choiceDevice(option, 3);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            String option = comboBox4.SelectedItem.ToString();
            choiceDevice(option, 4);
        }

        private void on1_Click(object sender, EventArgs e)
        {
            if (this.Slot1ON != null)
            {
                this.Slot1ON.Execute();
            }
        }

        private void off1_Click(object sender, EventArgs e)
        {
            if (this.Slot1OFF != null)
            {
                this.Slot1OFF.Execute();
                updateCouter();
            }
        }

        private void on2_Click(object sender, EventArgs e)
        {
            if (this.Slot2ON != null)
            {
                this.Slot2ON.Execute();
            }
        }

        private void off2_Click(object sender, EventArgs e)
        {
            if (this.Slot2OFF != null)
            {
                this.Slot2OFF.Execute();
                updateCouter();
            }
        }

        private void on3_Click(object sender, EventArgs e)
        {
            if (this.Slot3ON != null)
            {
                this.Slot3ON.Execute();
            }
        }

        private void off3_Click(object sender, EventArgs e)
        {
            if (this.Slot3OFF != null)
            {
                this.Slot3OFF.Execute(); 
                updateCouter();
            }
        }

        private void on4_Click(object sender, EventArgs e)
        {
            if (this.Slot4ON != null)
            {
                this.Slot4ON.Execute();
            }
        }

        private void off4_Click(object sender, EventArgs e)
        {

            if (this.Slot4OFF != null)
            {
                this.Slot4OFF.Execute();
                updateCouter();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       /* private void button3_Click(object sender, EventArgs e)
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
            
            
        }*/
        public void updateCouter()
        {
          counter.Text="Used: "+  busmeter.findMeter(idMeter).Meter_Count.ToString("N1");
        }

        private void admintratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager ma = new Manager();
            ma.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
