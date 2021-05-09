using System;
using System.Windows.Forms;
using System.Drawing;

namespace DTO_ELECTRIC
{
    public class DTO_Tivi : DTO_Device

    {
        private Button status;
        
       

        public DTO_Tivi(Button status, int meterID) : base("TIVI", 195f, 27f, meterID)
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

    public class DTO_Tivi_Off : ICommand
    {
        private DTO_Tivi tivi;

        public DTO_Tivi_Off(DTO_Tivi tivi)
        {
            this.tivi = tivi;
        }

        public void Execute()
        {
            this.tivi.turnOff();
        }
    }

    public class DTO_Tivi_On : ICommand
    {
        private DTO_Tivi tivi;

        public DTO_Tivi_On(DTO_Tivi tivi)
        {
            this.tivi = tivi;
        }

        public void Execute()
        {
            this.tivi.turnOn();
        }
    }
}
