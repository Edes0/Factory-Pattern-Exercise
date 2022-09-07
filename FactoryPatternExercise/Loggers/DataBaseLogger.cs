using FactoryPatternExercise.Contracts;

namespace FactoryPatternExercise.Loggers
{
    public class DataBaseLogger : ILogger
    {
        public void Log(string logData)
        {
            Console.WriteLine(logData);
        }
    }
}