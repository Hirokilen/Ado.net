using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace ReaderObject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                String oracledb = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=10.10.2.10)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=SLAM)));User Id = raimonsql; Password = sio; ";

                String connectionString = oracledb;
                OracleConnection connection = new OracleConnection();
                connection.ConnectionString = oracledb;
                connection.Open();


                Console.ReadKey();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }


        }
    }
}
