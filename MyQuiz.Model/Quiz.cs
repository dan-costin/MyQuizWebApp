using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiz.Model
{
    [Serializable]
    [Table("Quizzes")]
    public class Quiz
    {
        public Quiz()
        {
            Questions = new HashSet<Question>();
        }

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
