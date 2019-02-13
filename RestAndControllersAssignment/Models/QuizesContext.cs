using Microsoft.EntityFrameworkCore;
using RestAndControllersAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAndControllersAssignment.Models
{
    public class QuizesContext:DbContext
    {
        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }

        public QuizesContext(DbContextOptions<QuizesContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Quiz>()
                .HasIndex(u => u.QuizName)
                .IsUnique();
            builder.Entity<Answer>()
                .HasIndex(u => u.AnswerText)
                .IsUnique();
            builder.Entity<Question>()
                .HasIndex(u => u.QuestionText)
                .IsUnique();
        }
    }
}
