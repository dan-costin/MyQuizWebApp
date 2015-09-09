using System;

namespace MyQuiz.Logger
{
    public interface ILogger
    {
        void LogException(Exception exc, string source);
    }
}
