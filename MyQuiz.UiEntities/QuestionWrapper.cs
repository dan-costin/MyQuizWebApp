using System;
using MyQuiz.Model;

namespace MyQuiz.UiEntities
{
    [Serializable]
    public class QuestionWrapper
    {
        public QuestionWrapper()
        {
            Answer = new Answers();
        }

        public QuestionWrapper(Question question)
        {
            Question = question;
            Answer = new Answers();
        }

        public Question Question { get; set; }
        public Answers Answer { get; set; }
        public bool IsQuestionAnswered { get; set; }
    }
}
