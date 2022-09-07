using FactoryPatternExercise.Contracts;
using FactoryPatternExercise.Loggers;

namespace FactoryPatternExercise.Factories
{
    public class DataBaseLoggerFactory : LoggerFactory
    {
        public override ILogger Create()
        {
            ILogger logger = new DataBaseLogger();

            return (logger);
        }
    }
}