using System;
using System.Collections.Generic;
using System.Text;
using DTO_ELECTRIC;
using System.Windows.Forms;

namespace DAL_ELECTRIC
{
    public class DAL_Factory_Device
    {
        public enum TypeDevice
        {
            FAN,LIGHT,TIVI,DIEUHOA
        }
        private DAL_Factory_Device() { }
        public static  DTO_Device createDevice(TypeDevice typeDevice,Button btn,int idMeter)
        {
            switch (typeDevice)
            {
                case TypeDevice.FAN:
                    {
                        return new DTO_Fan(btn, idMeter);
                       
                    }
                case TypeDevice.LIGHT:
                    {
                        return new DTO_Light(btn, idMeter);

                    }
                case TypeDevice.TIVI:
                    {
                        return new DTO_Tivi(btn, idMeter);

                    }
                case TypeDevice.DIEUHOA:
                    {
                        return new DTO_DIEUHOA(btn, idMeter);

                    }
                default:
                    {
                        return new DTO_Light(btn, idMeter);
                    }
            }
        }
    }
}
