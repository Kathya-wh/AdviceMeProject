using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagesProject.Models
{
    public class Message
    {


        public Message()
        {

        }
        public int MessageID { get; set; }
        public string MessageInput { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }

    }


}
