using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Data.SqlClient;

namespace DTO_ELECTRIC
{
    public abstract class DTO_Device
    {
        private String device_Name;
        private float device_Von;
        private float device_Ampe;
      
        private int meterID;
        private int timeOn = 0;
        private System.Timers.Timer timeout;
        private InterVal myInterVal = new InterVal();
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-65P28BH;Initial Catalog=ELECTRIC_MANAGER;Integrated Security=True");

        protected DTO_Device(string device_Name, float device_Von, float device_Ampe, int meterID)
        {
            this.device_Name = device_Name;
            this.device_Von = device_Von;
            this.device_Ampe = device_Ampe;
            this.meterID = meterID;
        }

        protected string Device_Name { get => device_Name; set => device_Name = value; }
        protected float Device_Von { get => device_Von; set => device_Von = value; }
        protected float Device_Ampe { get => device_Ampe; set => device_Ampe = value; }
        public int TimeOn { get => timeOn; set => timeOn = value; }
        public int MeterID { get => meterID; set => meterID = value; }

        public abstract void turnOn();
        public abstract void turnOff();

        public void use()
        {
            this.timeout = myInterVal.interval(() =>
             {
                 timeOn += 1;
            
             }, 1000);
        }
        public void stop()
        {
            myInterVal.clearInterval(timeout);
            DTO_Meter myMeter = this.findMeter(meterID);
          
            myMeter.Meter_Count += calA();
            timeOn = 0;
            this.editMeter(myMeter);

        }
        private float calA()
        {
            return (timeOn * device_Ampe * device_Von)/3600;
        }

        private bool editMeter(DTO_Meter meter)
        {
            try
            {
                _conn.Open();
             
                String SQL = String.Format("UPDATE Meter set _METER_COUNT ='{0}'  where _METER_ID = '{1}'", meter.Meter_Count, meter.Meter_ID);
                

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        private DTO_Meter findMeter(int idMeter)
        {
            try
            {
                _conn.Open();
                String SQL = String.Format("SELECT * FROM Meter WHERE _METER_ID = '{0}'", idMeter);
              

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    return new DTO_Meter(int.Parse(reader[0].ToString()), float.Parse(reader[1].ToString()));



                }
                else
                {
                    return new DTO_Meter();
                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return new DTO_Meter();
        }


    }
}
