using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace ReaderObject
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleConnection CnOracle;
            String Cn = "Data Source=raimonsql;User Id=raimonsql; Password=sio";
            CnOracle = new OracleConnection();
            CnOracle.ConnectionString = Cn;
            CnOracle.Open();

            OracleCommand cmd = new OracleCommand();
            string cmdEmp = " select * from employe";
            OracleDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                        reader.GetString(1));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
        

        }
    }
}
