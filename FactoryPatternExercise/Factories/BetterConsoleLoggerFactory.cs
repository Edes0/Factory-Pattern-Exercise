
using FactoryPatternExercise.Contracts;
using FactoryPatternExercise.Loggers;

namespace FactoryPatternExercise.Factories
{
    public class BetterConsoleLoggerFactory : LoggerFactory
    {
        public override ILogger Create()
        {
            ILogger logger = new ConsoleLogger();

            Console.WriteLine("Look at me, im better!");

            return (logger);
        }
    }
}