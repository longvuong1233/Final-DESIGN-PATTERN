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


namespace GUI_ELECTRIC
{
    public partial class Login : Form
    {

        
        private BUS_Customer busCustomer = new BUS_Customer();
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String phone = inputPhone.Text.Trim();
            if (phone != "")
            {
                if (phone == "admin")
                {
                    Manager managerForm = new Manager();
                    managerForm.Show();
                    this.Hide();
                }
                else
                {
                    PhoneValidation phoneValidation = new PhoneValidation(phone);
                    if (phoneValidation.validate() == true)
                    {
                        bool result = busCustomer.hasCustomer(phone);
                        if (result == true)
                        {
                            Program.phoneClient = phone;
                            Client clientForm = new Client();
                            clientForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            message.Text = "Phone is not exist";
                        }
                    }
                    else
                    {
                        message.Text = "Phone is invalid";
                    }
                    
                }
               
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
