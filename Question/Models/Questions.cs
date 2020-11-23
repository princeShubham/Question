using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Question.Models
{

    public enum QuestionType : int
    {
       Subjective = 0,
        Objective = 1,
    }
    public class Questions
    {
        [Key]
        public int questionId { get; set; }

        public int SkillGroupId { get; set; }

        public  QuestionType Questionss { get;  }


    }
}