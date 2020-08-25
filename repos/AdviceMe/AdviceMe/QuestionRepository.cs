using AdviceMe.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
//using Ubiety.Dns.Core;

namespace AdviceMe
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
            return _connection.Query<Question>("SELECT * FROM questions");
        }

        public Question GetQuestion(int questionID)
        {
            return _connection.QuerySingle<Question>("Select * FROM questions WHERE QuestionID = @questionID", new { questionID = questionID });
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _connection.Query<Category>("SELECT * FROM categories");
        }
        public Question AssignCategory()
        {
            var categoryList = GetAllCategories();
            var question = new Question();
            question.Categories = categoryList;
            return question;
        }

       /* public void UpdateQuestion(Question question)
        {
            _connection.Execute("UPDATE questions SET QuestionInput = @questionInput WHERE QuestionID = @id",
                new {questionInput = question.QuestionInput, id = question.QuestionID });
        }*/

        public void CreateQuestion(Question question)
        {
            _connection.Execute("INSERT INTO questions (QuestionInput, CategoryID, UserID) VALUES (@questionInput, @categoryID, @userID)",
                new {questionInput = question.QuestionInput, categoryID = question.CategoryID, userID = question.UserID });
           
        }
        public void EditQuestion(Question questionToEdit)
        {
            _connection.Execute("UPDATE questions SET QuestionInput = @questionInput, CategoryID = @categoryID WHERE QuestionID = @questionID ",
            new { questionInput = questionToEdit.QuestionInput, categoryID = questionToEdit.CategoryID, questionID = questionToEdit.QuestionID });
        }
        public void DeleteQuestion(Question question)
        {
            _connection.Execute("DELETE FROM questions WHERE QuestionID = @id;", 
                new { id = question.QuestionID});
        }

       // public void UpdateQuestion(Question question)
        //{
            //throw new NotImplementedException();
      // }
    }
}

   
    
