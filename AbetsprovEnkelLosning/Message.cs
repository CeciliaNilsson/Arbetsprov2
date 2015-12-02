using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbetsprovEnkelLosning
{
    public class Message
    {
        public Message(DateTime dateAndTime, string textMessage)
        {
            DateAndTime = dateAndTime;
            TextMessage = textMessage;
        }

        public DateTime DateAndTime { get; set; }
        public string TextMessage { get; set; }
    }
}
