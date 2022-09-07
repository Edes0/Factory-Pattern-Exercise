using FactoryPatternExercise.Contracts;

namespace FactoryPatternExercise.Loggers
{
    class ConsoleLogger : ILogger
    {
        public void Log(string logData)
        {
            Console.WriteLine(logData);
        }
    }
}