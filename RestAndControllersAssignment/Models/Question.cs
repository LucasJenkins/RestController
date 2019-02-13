using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAndControllersAssignment.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }
        public string ActualAnswer { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
