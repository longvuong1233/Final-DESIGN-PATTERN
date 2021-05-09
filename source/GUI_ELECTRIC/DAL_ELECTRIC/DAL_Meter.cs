using System;
using System.Collections.Generic;
using System.Text;
using DTO_ELECTRIC;
using System.Data.SqlClient;
using System.Data;
namespace DAL_ELECTRIC
{
    public class DAL_Meter : DBConnect
    {
        public DataTable getMeter()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Meter", _conn);
            DataTable dtMeter = new DataTable();
            da.Fill(dtMeter);
            return dtMeter;
        }
        public DTO_Meter findMeter(int idMeter)
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
                    return new DTO_Meter(int.Parse(reader[0].ToString()),float.Parse( reader[1].ToString()));



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

        public bool addMeter(DTO_Meter meter)
        {
            try
            {
                _conn.Open();
                String SQL = String.Format("INSERT INTO Meter(_METER_COUNT) VALUES ('{0}')", meter.Meter_Count);


                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool editMeter(DTO_Meter meter)
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

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool deleteMeter(int meterID)
        {
            try
            {
                _conn.Open();
                String SQL = String.Format("DELETE Meter where _METER_ID = '{0}'", meterID);


                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
