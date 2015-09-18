using System;
using MyQuiz.Model;
using MyQuiz.Repository;
using System.Collections.Generic;
using MyQuiz.UiEntities;

namespace MyQuiz.Services
{
    [Serializable]
    public class QuizService : IQuizService
    {
        public QuestionWrapper NextQuestion { get; set; }

        QuestionWrapper _previousQuestion;

        Quiz _Quiz;
        int questionIndex = 0;
        int points = 0;

        public QuizService()
        {
        }

        public void SetQuiz(IQuizRepository quizRepository, int quizId)
        {
            _Quiz = quizRepository.GetQuiz(quizId);
        }

        public void GetNextQuestion()
        {
            if (_Quiz == null || _Quiz.Questions == null)
            {
                return;
            }

            Question question = GetItemAtIndex(_Quiz.Questions, questionIndex);
            NextQuestion = new QuestionWrapper(question);
            questionIndex++;
        }

        public void AnswerQuestion()
        {
            Question question = GetItemAtIndex(_Quiz.Questions, questionIndex - 2);
            for (int i = 0; i < question.Answers.Count; i++)
            {
                var quest = GetItemAtIndex(question.Answers, i);
            }

            //if (question.IsAnswer1Correct == _previousQuestion.Answer.Answer1 &&
            //    question.IsAnswer2Correct == _previousQuestion.Answer.Answer2 &&
            //    question.IsAnswer3Correct == _previousQuestion.Answer.Answer3 &&
            //    question.IsAnswer4Correct == _previousQuestion.Answer.Answer4)
            //{
            //    points += 1;
            //}
        }

        private Question GetItemAtIndex(ICollection<Question> questions, int questionIndex)
        {
            int collectionIndex = 0;
            foreach (var question in questions)
            {
                if (questionIndex == collectionIndex)
                    return question;
                collectionIndex++;
            }
            return null;
        }

        private Answer GetItemAtIndex(ICollection<Answer> questions, int questionIndex)
        {
            int collectionIndex = 0;
            foreach (var question in questions)
            {
                if (questionIndex == collectionIndex)
                    return question;
                collectionIndex++;
            }
            return null;
        }
    }
}
