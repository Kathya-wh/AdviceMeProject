using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdviceMe.Models
{
    public class Answer
    {
        public Answer()
        {
        }

        public int AnswerID { get; set; }
        public string AnswerInput { get; set; }
        public int QuestionID { get; set; }
        public string ReferenceURL { get; set; }
        public int UserID { get; set; }

    }
}
