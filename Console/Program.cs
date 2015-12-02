using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Meddelande (Enter för att skicka || Esc för att avsluta programmet):");
            UsersMessage();
        }

        public static void UsersMessage()
        {
            string message = "";
            while (System.Console.ReadKey().Key != ConsoleKey.Escape)
            {
                message = System.Console.ReadLine();
                SqlConnection myConnection = new SqlConnection(@"Data Source=ACADEMY27-VM\SQLEXPRESS; Initial Catalog= MessagesAteaGLobalServices;Integrated Security=True");

                SqlCommand myCommand = new SqlCommand();
                myCommand.CommandText = "SP_logging";
                myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                myCommand.Parameters.Add("@DateAndTime", System.Data.SqlDbType.DateTime);
                myCommand.Parameters.Add("@Message", System.Data.SqlDbType.VarChar);

                myCommand.Parameters["@DateAndTime"].Value = DateTime.Now;
                myCommand.Parameters["@Message"].Value = message;

                try
                {
                    myConnection.Open();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.ToString());
                }

                myCommand.Connection = myConnection;

                myCommand.ExecuteNonQuery();
                try
                {
                    myConnection.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.ToString());
                }
           }
        }
    }
}
