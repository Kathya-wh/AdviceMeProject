using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewAdviceMe.Controllers
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

       // public IActionResult ViewQuestion(int id)
        //{
           // var question = _repo.GetQuestion(id);

           // return View(question);
       // }



    }
}



    

