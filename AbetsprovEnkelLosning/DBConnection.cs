using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AbetsprovEnkelLosning
{
    public class DBConnection
    {
        public List<Message> UsersMessage()
        {
            DateTime thisDateAndTime;
            string thisMessage = "";
            List<Message> messages = new List<Message>();
            SqlDataReader myReader = null;

            SqlConnection myConnection = new SqlConnection(@"Data Source=ACADEMY27-VM\SQLEXPRESS; Initial Catalog= MessagesAteaGLobalServices;Integrated Security=True");

            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Något gick tyvärr fel: " + e.ToString());
            }

            try
            {
                var myCommand = new SqlCommand("SELECT * FROM Messages", myConnection);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    thisDateAndTime = (DateTime)myReader["DateAndTime"];
                    thisMessage = myReader["Message"].ToString();
                    Message message = new Message(thisDateAndTime, thisMessage);
                    messages.Add(message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Något gick tyvärr fel: " + e.ToString());
            }
            return messages;
        }
    }
}