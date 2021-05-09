using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace DTO_ELECTRIC
{
    public class DTO_DIEUHOA : DTO_Device
    {

        private Button status;

        public DTO_DIEUHOA(Button status, int meterID) : base("DIEU HOA", 2200, 75f, meterID)
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
    public class DTO_DIEUHOA_Off : ICommand
    {
        private DTO_DIEUHOA dieuhoa;

        public DTO_DIEUHOA_Off(DTO_DIEUHOA dieuhoa)
        {
            this.dieuhoa = dieuhoa;
        }

        public void Execute()
        {
            this.dieuhoa.turnOff();
        }
    }

    public class DTO_DIEUHOA_On : ICommand
    {
        private DTO_DIEUHOA dieuhoa;

        public DTO_DIEUHOA_On(DTO_DIEUHOA dieuhoa)
        {
            this.dieuhoa = dieuhoa;
        }

        public void Execute()
        {
            this.dieuhoa.turnOn();
        }
    }

}
