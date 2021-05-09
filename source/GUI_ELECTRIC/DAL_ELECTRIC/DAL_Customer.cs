using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO_ELECTRIC;

namespace DAL_ELECTRIC
{
    public class DAL_Customer : DBConnect
    {
        public DataTable getCustomer()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer", _conn);
            DataTable dtCustomer = new DataTable();
            da.Fill(dtCustomer);
            return dtCustomer;
        }
        public DTO_Customer findCustomer(int idCustomer)
        {
            try
            {
                _conn.Open();
                String SQL = String.Format("SELECT * FROM Customer WHERE _CUSTOMER_ID = '{0}'", idCustomer);


                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int idMeter = 0;
                    if (!reader.IsDBNull(5))
                    {

                        idMeter = int.Parse(reader[5].ToString());
                    }
                    return new DTO_Customer(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[4].ToString(), idMeter, reader[3].ToString());
            

                }
                else
                {
                    return new DTO_Customer();
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
            return new DTO_Customer();
        }

        public DTO_Customer findByPhone(String phone)
        {
            try
            {
                _conn.Open();
                String SQL = String.Format("SELECT * FROM Customer WHERE _CUSTOMER_PHONE = '{0}'", phone);


                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                  
                    int idMeter = 0;
                    if (!reader.IsDBNull(5))
                    {
                      
                        idMeter = int.Parse(reader[5].ToString());
                    }
                    return new DTO_Customer(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), reader[4].ToString(), idMeter, reader[3].ToString());



                }
                else
                {
                    return new DTO_Customer();
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
            return new DTO_Customer();
        }


        public bool addCustomer(DTO_Customer customer)
        {
            try
            {
                _conn.Open();
                String SQL = String.Format("INSERT INTO Customer(_CUSTOMER_NAME,_CUSTOMER_PHONE,_CUSTOMER_ADDRESS,_CUSTOMER_KIND) VALUES ('{0}','{1}','{2}','{3}')", customer.CUSTOMER_NAME,customer.CUSTOMER_PHONE,customer.CUSTOMER_ADDRESS,customer.CUSTOMER_KIND);


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

        public bool editCustomer(DTO_Customer customer)
        {
            try
            {
                _conn.Open();
                String SQL = String.Format("UPDATE Customer set _CUSTOMER_NAME ='{0}' ,_CUSTOMER_PHONE= '{1}',_CUSTOMER_ADDRESS = '{2}', _METER_ID='{3}' , _CUSTOMER_KIND='{4}' where _CUSTOMER_ID = '{5}'", customer.CUSTOMER_NAME, customer.CUSTOMER_PHONE, customer.CUSTOMER_ADDRESS, customer.METER_ID,customer.CUSTOMER_KIND,customer.CUSTOMER_ID);
                Console.WriteLine(SQL);

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

        public bool deleteCustomer(int CustomerID)
        {
            try
            {
                _conn.Open();
                String SQL = String.Format("DELETE Customer where _CUSTOMER_ID = '{0}'", CustomerID);


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

        
        public bool hasCustomer(String customerPhone)
        {
            try
            {
                _conn.Open();
                String SQL = String.Format("SELECT * FROM Customer WHERE _CUSTOMER_PHONE = '{0}'", customerPhone);


                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    /*reader.Read();*/
                    return true;
                    /* if (reader[0].ToString() == "Phòng nhân sự")
                     {
                         dock = 1;
                     }
                     else if (reader[0].ToString() == "Phòng kỹ thuật")
                     {
                         dock = 2;
                     }
                     return true;*/

                }
                else
                {
                    return false;
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
    }

   
}
