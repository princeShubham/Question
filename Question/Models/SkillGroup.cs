using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Question.Models
{
    public enum skillsenum : int
    {
        Beginner = 0,
        Intermediate = 1,
        Advanved = 2
    }

  
    public class SkillGroup
    {
     [Key]
        public int SkillGroupId { get; set; }
        public string SkillGroupName { get; set; }

        [Display(Name = "Skill Level")]
        public skillsenum Skill { get; set; }

      


    }
}