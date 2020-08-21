using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdviceMe.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdviceMe.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _repo;
        

        public QuestionController(IQuestionRepository repo)
        {
            _repo = repo;
        }





        public IActionResult Index()
        {
            var questions = _repo.GetAllQuestions();
            return View(questions);
        }

        public IActionResult ViewQuestion(int id)
        {
            var question = _repo.GetQuestion(id);

                return View(question);
        }

        public IActionResult CreateQuestion()
        {
            var question = _repo.AssignCategory();
            return View(question);
        }
        public IActionResult InsertQuestionToDataBase(Question questionToInsert)
        {
            _repo.CreateQuestion(questionToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult EditQuestion(int id)
        {
            Question ques = _repo.GetQuestion(id);
            ques.Categories = _repo.GetAllCategories();

            if (ques == null)
            {
                return View("Question not found");
            }
            return View(ques);
        }
        public IActionResult UpdateQuestion(int id)
        {
            Question ques = _repo.GetQuestion(id);
            if (ques == null)
            {
                return View("QuestiontNotFound");
            }
            return View(ques);
        }
        public IActionResult UpdateQuestionToDatabase(Question question)
        {
            _repo.UpdateQuestion(question);
            return RedirectToAction("ViewProduct", new { id = question.QuestionID });
        }

    }
}
