using FactoryPatternExercise.Contracts;
using FactoryPatternExercise.Loggers;

namespace FactoryPatternExercise.Factories
{
    public class ConsoleLoggerFactory : LoggerFactory
    {
        public override ILogger Create()
        {
            ILogger logger = new ConsoleLogger();

            return (logger);
        }
    }
}