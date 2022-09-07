using FactoryPatternExercise.Contracts;

namespace FactoryPatternExercise.Factories
{

    public abstract class LoggerFactory
    {
        public abstract ILogger Create();
    }
}