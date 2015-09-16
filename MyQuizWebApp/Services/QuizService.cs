using System;
using MyQuiz.Model;
using System.Collections.Generic;

namespace MyQuiz.Services
{
    [Serializable]
    public class QuizService : IQuizService
    {
        private Quiz _Quiz;
        private Question currentQuestion;
        private int questionIndex = 0;
        private int points = 0;

        public void SetQuiz(Quiz quiz)
        {
            _Quiz = quiz;
        }

        public Question GetNextQuestion()
        {
            if (_Quiz == null || _Quiz.Questions == null)
            {
                return null;
            }

            currentQuestion = GetItemAtIndex(_Quiz.Questions, questionIndex);
            questionIndex++;

            return currentQuestion;
        }

        public void AnswerQuestion(bool question1, bool question2, bool question3, bool question4)
        {
            if (currentQuestion.IsAnswer1Correct == question1 &&
                currentQuestion.IsAnswer2Correct == question2 &&
                currentQuestion.IsAnswer3Correct == question3 &&
                currentQuestion.IsAnswer4Correct == question4)
                points += 1;
        }

        private Question GetItemAtIndex(ICollection<Question> collection, int index)
        {
            int collectionIndex = 0;
            foreach (Question question in _Quiz.Questions)
            {
                if (index == collectionIndex)
                    return question;
                collectionIndex++;
            }
            return null;
        }
    }
}
