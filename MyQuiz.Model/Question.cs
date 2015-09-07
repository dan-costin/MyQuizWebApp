using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuiz.Model
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int ID { get; set; }
        public string QuestionText { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public bool IsAnswer1Correct { get; set; }
        public bool IsAnswer2Correct { get; set; }
        public bool IsAnswer3Correct { get; set; }
        public bool IsAnswer4Correct { get; set; }
    }
}
