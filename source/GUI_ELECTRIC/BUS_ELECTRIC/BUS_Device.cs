using System;
using System.Collections.Generic;
using System.Text;
using DAL_ELECTRIC;
using DTO_ELECTRIC;
using System.Windows.Forms;

namespace BUS_ELECTRIC
{
   public  class BUS_Device
    {

        private BUS_Device()
        {

        }

        public static DTO_Device createDevice(DAL_Factory_Device.TypeDevice typeDevice,Button  btn,int meterID)
        {
            return DAL_Factory_Device.createDevice(typeDevice, btn, meterID);
        }
    }
}
