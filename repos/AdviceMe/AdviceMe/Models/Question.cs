using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdviceMe.Models
{
    public class Question
    {
        public Question()
        {
        }

        public int QuestionID { get; set; }
        public string QuestionInput { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
