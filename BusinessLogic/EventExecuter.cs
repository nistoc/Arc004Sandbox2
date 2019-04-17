using System;
using System.Threading;
using System.Timers;
using Contracts;
using Contracts.Events;

namespace BusinessLogic
{
    public class EventExecuter : IEventExecuter
    {
        private readonly ICommandInterpreter _commandInterpreter;
        private readonly IDeviceEventTimer _event;

        public EventExecuter(IDeviceEventTimer deviceEventTimer, ICommandInterpreter commandInterpreter)
        {
            _commandInterpreter = commandInterpreter ?? throw new ArgumentNullException(nameof(commandInterpreter));
            _event = deviceEventTimer ?? throw new ArgumentNullException(nameof(deviceEventTimer));
        }
        public void Execute()
        {
            Thread.Sleep(_event.TimerSpanBeforeStart);
            _commandInterpreter.ExecuteCommand(_event.ExecutingEvent.Command);
        }

    }
}
