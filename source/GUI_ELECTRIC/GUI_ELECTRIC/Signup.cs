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
    public partial class Signup : Form
    {

        private BUS_Customer busCustomer = new BUS_Customer();
        public Signup()
        {
            InitializeComponent();
        }
        private void reInitialInput()
        {
            inputAddress.Text = "";
            inputName.Text = "";
            inputPhone.Text = "";
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            String name = inputName.Text.Trim();
            String phone = inputPhone.Text.Trim();
            String address = inputAddress.Text.Trim();
            String kind  ;
         
            if (comboBox1.SelectedItem == null)
            {
                kind = "";
            }
            else
            {
                kind = comboBox1.SelectedItem.ToString();
            }
      
           
            if (name != "" && phone != "" && address != "")
            {
                PhoneValidation phoneValidation = new PhoneValidation(phone);
                if (phoneValidation.validate() == true)
                {
                    KindCustomerValidation kindValidation = new KindCustomerValidation(kind);
                    if(kindValidation.validate() == true)
                    {
                        bool checkExist = busCustomer.hasCustomer(phone);
                        if (checkExist == true)
                        {
                            messageSignup.Text = "Phone was existed !!!";

                        }
                        else
                        {
                            Console.WriteLine(kind,"ha");
                            DTO_Customer newCustomer = new DTO_Customer(name, phone, address,kind);
                            bool result = busCustomer.addCustomer(newCustomer);
                            if (result == true)
                            {
                                messageSignup.Text = "Successful !!!";
                                reInitialInput();
                            }
                            else
                            {
                                messageSignup.Text = "Have Wrong !!!";
                            }
                        }
                    }
                    else
                    {
                        messageSignup.Text = "Kind is invalid !!!";
                    }
                    
                }
                else
                {
                    messageSignup.Text = "Phone is invalid !!!";
                }


            }

        }
    }
}
