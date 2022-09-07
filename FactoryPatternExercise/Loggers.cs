namespace FactoryPatterExercise
{
    public class ConsoleLogger
    {
        public void PrintToConsole(string logData)
        {
            Console.WriteLine(logData);
        }
    }
    public class FileLogger
    {
        public void PrintToFile(string logData)
        {
            Console.WriteLine(logData);
        }
    }
    public class DataBaseLogger
    {
        public void PrintToDataBase(string logData)
        {
            Console.WriteLine(logData);
        }
    }
}