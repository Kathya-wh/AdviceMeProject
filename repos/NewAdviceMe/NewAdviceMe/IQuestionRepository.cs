using NewAdviceMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAdviceMe
{
    public interface IQuestionRepository
    {
        public IEnumerable<Question> GetAllQuestions();
    }
}
