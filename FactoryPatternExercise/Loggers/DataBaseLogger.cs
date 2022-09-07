using FactoryPatternExercise.Contracts;

namespace FactoryPatternExercise.Loggers
{
    class DataBaseLogger : ILogger
    {
        public void Log(string logData)
        {
            Console.WriteLine(logData);
        }
    }
}