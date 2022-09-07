using FactoryPatterExercise;

DateTime lastLog = DateTime.Now;
var logType = "Console";

while (true)
{
    if (lastLog <= DateTime.Now)
    {
        var result = $"Important work was done at {DateTime.Now}";
        Log(result);

        lastLog = DateTime.Now.AddSeconds(10);
    }
}

void Log(string result)
{
    if (logType.ToLower() == "console")
    {
        var logger = new ConsoleLogger();
        logger.PrintToConsole(result);
    }

    if (logType.ToLower() == "file")
    {
        var logger = new FileLogger();
        logger.PrintToFile(result);
    }

    if (logType.ToLower() == "database")
    {
        var logger = new DataBaseLogger();
        logger.PrintToDataBase(result);
    }
}