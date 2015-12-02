using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AbetsprovEnkelLosning
{
    public partial class Webpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGetMessanges_Click(object sender, EventArgs e)
        {
            DBConnection getMessanges = new DBConnection();
            List<Message> messages = new List<Message>();
            messages = getMessanges.UsersMessage();

            ListBoxMessanges.Items.Clear();

            messages.Sort((message1, message2) => DateTime.Compare(message2.DateAndTime, message1.DateAndTime));
            messages.ForEach(p => ListBoxMessanges.Items.Add(p.TextMessage + " - " + p.DateAndTime));
        }

        protected void ListBoxMessanges_SelectedIndexChanged(object sender, EventArgs e) 
        {

        }
    }
}