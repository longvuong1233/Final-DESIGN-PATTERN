using System;
using System.Data.SqlClient;
namespace DAL_ELECTRIC
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-65P28BH;Initial Catalog=ELECTRIC_MANAGER;Integrated Security=True");
    }
}
