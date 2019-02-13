using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAndControllersAssignment.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; } = false;
        public bool Deleted { get; set; } = false;
    }
}
