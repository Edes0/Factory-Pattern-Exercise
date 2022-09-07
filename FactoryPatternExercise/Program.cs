using FactoryPatternExercise.Contracts;
using FactoryPatternExercise.Factories;

DateTime lastLog = DateTime.Now;
var logType = LoggerType.Console;

while (true)
{
    if (lastLog <= DateTime.Now)
    {
        ILogger logger = LoggerFactory.CreateLogger(logType);

        var result = $"Important work was done at {DateTime.Now}";
        logger.Log(result);

        lastLog = DateTime.Now.AddSeconds(10);
    }
}