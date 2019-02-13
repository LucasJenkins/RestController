using RestAndControllersAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAndControllersAssignment.Services
{
    public interface IQuizServices
    { 
        List<Quiz> GetTheQuizes();
        Quiz CreateQuiz(Quiz quiz);
        Quiz DeleteQuiz(int id);
        Quiz RenameQuiz(int id, string name);
        Quiz AddQuestion(int quizId, Question question);
        Question DeleteQuestion(int questionId, int quizId);
        Quiz GetQuiz(int id);
    }
}
