using FactoryPatternExercise.Contracts;
using FactoryPatternExercise.Loggers;

namespace FactoryPatternExercise.Factories
{
    internal enum LoggerType
    {
        Console,
        File,
        DataBase
    }

    public static class LoggerFactory
    {

        internal static ILogger CreateLogger(LoggerType type)
        {
            ILogger logger = null;

            switch (type)
            {
                case LoggerType.Console:
                    logger = new ConsoleLogger();
                    break;

                case LoggerType.File:
                    logger = new FileLogger();
                    break;

                case LoggerType.DataBase:
                    logger = new DataBaseLogger();
                    break;

                default:
                    throw new NotImplementedException();
            }

            return logger;
        }
    }
}