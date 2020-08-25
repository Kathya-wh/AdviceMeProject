using Dapper;
using MessagesProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MessagesProject
{
   
    public class MessageRepository : IMessageRepository
    {
        private readonly IDbConnection _connection;
        public MessageRepository(IDbConnection connection)
        {
            _connection = connection;
        }
       
        public IEnumerable<Message> GetAllMessages()
        {
            return _connection.Query<Message>("SELECT * FROM messages;");
        }
    }
}
