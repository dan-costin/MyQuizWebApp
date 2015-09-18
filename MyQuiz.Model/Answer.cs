using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuiz.Model
{
    [Serializable]
    [Table("Answers")]
    public class Answer
    {
        [Key]
        public int ID { get; set; }
        public string AnswerText { get; set; }
        public bool IsAnswerCorrect { get; set; }
    }
}
