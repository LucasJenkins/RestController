using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestAndControllersAssignment.Models;
using RestAndControllersAssignment.Services;

namespace RestAndControllersAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private IQuizServices _quizService;

        public QuizController(IQuizServices quizServices)
        {
            _quizService = quizServices;
        }

        // GET api/Quiz
        [HttpGet]
        public ActionResult<IEnumerable<IQuizServices>> GetQuizes()
        {
            var results = _quizService.GetTheQuizes();
            return Ok(results);
        }

        // GET api/Quiz/{id}
        [HttpGet("{id}")]
        public ActionResult<IQuizServices> GetQuiz(int id)
        {
            var results = _quizService.GetQuiz(id);
            return Ok(results);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<IQuizServices> CreateQuiz([FromBody] Quiz value)
        {
            var results = _quizService.CreateQuiz((Quiz) value);
            return Ok(results);
        }

        // PUT api/values/5
        [HttpPatch("{id}/rename/{value}")]
        public ActionResult<IQuizServices> UpdateQuizName(int id, string value)
        {
            var results = _quizService.RenameQuiz(id, value);
            return Ok(results);
        }

        // DELETE api/values/5
        [HttpDelete("delete/{id}")]
        public ActionResult<IQuizServices> Delete(int id)
        {
            var result = _quizService.DeleteQuiz(id);
            return Ok(result);
        }
    }
}
