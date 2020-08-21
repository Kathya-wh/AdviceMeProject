using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdviceMe.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdviceMe.Controllers
{
    public class AnswerController : Controller
    {
        private readonly IAnswerRepository _repo;
       
        public AnswerController(IAnswerRepository repo)
        {
            _repo = repo;
        }

     
        public IActionResult Index()
        {
            var answers = _repo.GetAllAnswers();

            return View(answers);
        }
        public IActionResult ViewAnswer(int id)
        {
            var answer = _repo.GetAnswer(id);

            return View(answer);
        }

        public IActionResult InsertAnswerToDataBase(Answer answerToInsert)
        {
            _repo.CreateAnswer(AnswerToInsert);
            return RedirectToAction("Index");
        }

    }
}
