using System;
using System.Collections.Generic;
using System.Text;
using DAL_ELECTRIC;
using DTO_ELECTRIC;
using System.Data;
namespace BUS_ELECTRIC
{
    public class BUS_Meter
    {

        private DAL_Meter dalMeter = new DAL_Meter();

        public DataTable getMeter()
        {
            return dalMeter.getMeter();
        }

        public bool addMeter(DTO_Meter meter)
        {
            return dalMeter.addMeter(meter);
        }

        public bool deleteMeter(int meterID)
        {
            return dalMeter.deleteMeter(meterID);
        }
        public bool editMeter(DTO_Meter meter)
        {
            return dalMeter.editMeter(meter);
        }
        public DTO_Meter findMeter(int idMeter)
        {
            return dalMeter.findMeter(idMeter);
        }
    }
}
