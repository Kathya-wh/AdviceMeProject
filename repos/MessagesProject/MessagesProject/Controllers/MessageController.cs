using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessagesProject.Models;

namespace MessagesProject.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageRepository _repo;

        public MessageController(IMessageRepository repo)
        {
            _repo = repo;
        }


        public IActionResult Index()
        {
            var message = _repo.GetAllMessages();
            return View(message);
        }
       
    }
}
