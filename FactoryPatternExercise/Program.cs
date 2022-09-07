using FactoryPatternExercise.Contracts;
using FactoryPatternExercise.Factories;

DateTime lastLog = DateTime.Now;

while (true)
{
    if (lastLog <= DateTime.Now)
    {
        LoggerFactory loggerFactory = new BetterConsoleLoggerFactory();
        ILogger logger = loggerFactory.Create();


        var result = $"Important work was done at {DateTime.Now}";
        logger.Log(result);

        lastLog = DateTime.Now.AddSeconds(10);
    }
}