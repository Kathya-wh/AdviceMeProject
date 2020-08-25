using Dapper;
using NewAdviceMe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace NewAdviceMe
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IDbConnection _connection;

        public QuestionRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Question> GetAllQuestions()
        {
            return _connection.Query<Question>("SELECT * FROM Questions;");
        }

    }
}
