using AdviceMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdviceMe
{
    public interface IAnswerRepository
    {
        public IEnumerable<Answer> GetAllAnswers();
        public Answer GetAnswer(int answerID);
        public void CreateAnswer(Answer answer);
    }
}
