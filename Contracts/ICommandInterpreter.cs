using Contracts.Events;

namespace Contracts
{
    public interface ICommandInterpreter
    {
        void ExecuteCommand(string command);
    }
}
