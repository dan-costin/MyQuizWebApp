using MyQuiz.Model;
using System;
using System.Data.Entity;

namespace MyQuiz.Repository
{
    public class MyQuizDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuizHistory> QuizzesHistory { get; set; }
    }
}
