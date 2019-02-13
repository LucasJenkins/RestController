using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAndControllersAssignment.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string QuizName { get; set; }
        public List<Question> Questions { get; set; }
        public bool Deleted { get; set; } = false;

        public Quiz()
        {

        }
        public Quiz(string name)
        {
            QuizName = name;
        }
    }
}
