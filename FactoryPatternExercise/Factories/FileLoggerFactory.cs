using FactoryPatternExercise.Contracts;
using FactoryPatternExercise.Loggers;

namespace FactoryPatternExercise.Factories
{
    public class FileLoggerFactory : LoggerFactory
    {
        public override ILogger Create()
        {
            ILogger logger = new FileLogger();

            return (logger);
        }
    }
}