using FactoryPatternExercise.Contracts;

namespace FactoryPatternExercise.Loggers
{
    class FileLogger : ILogger
    {
        public void Log(string logData)
        {
            Console.WriteLine(logData);
        }
    }
}