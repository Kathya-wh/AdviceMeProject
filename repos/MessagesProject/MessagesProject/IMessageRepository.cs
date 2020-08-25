using MessagesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagesProject
{
    public interface IMessageRepository
    {
        public IEnumerable<Message> GetAllMessages();
    }
}
