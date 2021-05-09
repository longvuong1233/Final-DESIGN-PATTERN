using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DTO_ELECTRIC
{
    public class DTO_Fan : DTO_Device
    {
        private Button status;
       

        public DTO_Fan(Button status,int meterID) : base("FAN", 120f, 5.0f, meterID)
        {
            this.status = status;
            this.status.BackColor = Color.Gray;
        }

     

        public override void turnOff()
        {
            this.status.BackColor = Color.Gray;
            this.stop();
        }

        public override void turnOn()
        {
            this.status.BackColor = Color.Green;
            this.use();
        }
    }

    public class DTO_Fan_On : ICommand
    {
        private DTO_Fan fan;

        public DTO_Fan_On(DTO_Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            this.fan.turnOn();
        }
    }
    public class DTO_Fan_Off : ICommand
    {
        private DTO_Fan fan;

        public DTO_Fan_Off(DTO_Fan fan)
        {
            this.fan = fan;
        }

        public void Execute()
        {
            this.fan.turnOff();
        }
    }
}
