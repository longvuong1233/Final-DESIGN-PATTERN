using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DTO_ELECTRIC
{
    public class DTO_Light : DTO_Device
    {

        private Button status;
       

        public DTO_Light(Button status,int meterID) : base("LIGHT", 20, 33f, meterID)
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

    public class DTO_Light_On : ICommand
    {
        private DTO_Light light;

        public DTO_Light_On(DTO_Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.turnOn();
        }
    }
    public class DTO_Light_Off : ICommand
    {
        private DTO_Light light;

        public DTO_Light_Off(DTO_Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.turnOff();
        }
    }
}
