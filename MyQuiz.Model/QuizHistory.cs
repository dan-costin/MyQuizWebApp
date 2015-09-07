using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiz.Model
{
    [Table("QuizzesHistory")]
    public class QuizHistory
    {
        [Key]
        public int ID { get; set; }
        public User User { get; set; }
        public Quiz QuizTaken { get; set; }
        public int Score { get; set; }
    }
}
