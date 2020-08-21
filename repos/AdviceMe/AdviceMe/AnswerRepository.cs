using AdviceMe.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AdviceMe
{
    public class AnswerRepository : IAnswerRepository
    {

        private readonly IDbConnection _connection;
        public AnswerRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Answer> GetAllAnswers()
        {
            return _connection.Query<Answer>("SELECT * FROM answers");
        }

        public Answer GetAnswer(int answerID)
        {
            return _connection.QuerySingle<Answer>("Select * FROM answers WHERE AnswerID = @answerID", new { answerID = answerID });
        }
        
    }
}
