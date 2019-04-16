using Contracts.Events;

namespace BusinessLogic
{
    public interface IEventExecuter
    {
        IDeviceEventTimer Event { get; }

        void Execute();
    }
}
