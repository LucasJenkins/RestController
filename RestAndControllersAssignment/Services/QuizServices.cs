using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAndControllersAssignment.Models;

namespace RestAndControllersAssignment.Services
{
    public class QuizServices : IQuizServices
    {
        private QuizesContext _quizesContext;

        public QuizServices(QuizesContext quizesContext)
        {
            this._quizesContext = quizesContext;
        }

        public Quiz GetQuiz(int id)
        {
            return _quizesContext.Quiz.Single(q1 => q1.Id == id);
        }

        Quiz IQuizServices.AddQuestion(int quizId, Question question)
        {
            var quiz = GetQuiz(quizId);
            quiz.Questions.Add(question);
            _quizesContext.Quiz.Update(quiz);
            _quizesContext.SaveChanges();
            return quiz;
        }

        Quiz IQuizServices.CreateQuiz(Quiz quiz)
        {
            _quizesContext.Quiz.Add(quiz);
            _quizesContext.SaveChanges();
            return quiz;          
        }

        Question IQuizServices.DeleteQuestion(int questionId, int quizId)
        {
            var question = _quizesContext.Question.First(q1 => q1.Id == questionId);
            question.Deleted = true;
            _quizesContext.Question.Update(question);
            _quizesContext.SaveChanges();
            return question;
        }

        Quiz IQuizServices.DeleteQuiz(int id)
        {
            var quiz = GetQuiz(id);
            quiz.Deleted = true;
            _quizesContext.Quiz.Update(quiz);
            _quizesContext.SaveChanges();
            return quiz;
        }

        List<Quiz> IQuizServices.GetTheQuizes()
        {
            return _quizesContext.Quiz.ToList();
        }

        Quiz IQuizServices.RenameQuiz(int id, string name)
        {
            var quiz = GetQuiz(id);
            quiz.QuizName = name;
            _quizesContext.Quiz.Update(quiz);
            _quizesContext.SaveChanges();
            return quiz;
        }
    }
}
