using AdviceMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdviceMe
{
    public interface IQuestionRepository
    {

        public IEnumerable<Question> GetAllQuestions();
        public Question GetQuestion(int questionID);
        public IEnumerable<Category> GetAllCategories();
        public Question AssignCategory();
        public void UpdateQuestion(Question question);
        public void CreateQuestion(Question question);
        public void EditQuestion(Question question);
        
    }

}
