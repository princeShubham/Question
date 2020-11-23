using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Question.Models
{
    public class Answer
    {
        public int answerId { get; set; }

        public int questionId { get; set; }

        
        public bool option1 { get; set; }

        public bool option2 { get; set; }
        public bool option3 { get; set; }
        public bool option4 { get; set; }

        public string answer  { get; set; }



    }
}