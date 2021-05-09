using System;
using System.Collections.Generic;
using System.Text;


namespace DTO_ELECTRIC
{
    public class DTO_Meter
    {

        private int _Meter_ID;
        private float _Meter_Count;


        public DTO_Meter()
        {

         
        }

        public DTO_Meter(float meter_Count)
        {

            _Meter_Count = meter_Count;
        }

        public DTO_Meter(int meter_ID, float meter_Count)
        {
            _Meter_ID = meter_ID;
            _Meter_Count = meter_Count;
        }

        public int Meter_ID { get => _Meter_ID; set => _Meter_ID = value; }
        public float Meter_Count { get => _Meter_Count; set => _Meter_Count = value; }
    }
}
