using System;
using System.Collections.Generic;
using System.Timers;
using Contracts;
using Contracts.Events;

namespace BusinessLogic.Scenarios
{
    public class ConcreteScenarioActor : IScenarioActor
    {
        private Timer timer;
        private List<IEventExecuter> EventExecuters { get; } = new List<IEventExecuter>();

        public int ScenarioId { get; set; }

        public ConcreteScenarioActor(List<IDeviceEventTimer> eventExecuters, ICommandInterpreter commandInterpreter)
        {
            eventExecuters.ForEach(c =>
            {
                EventExecuters.Add(new EventExecuter(c, commandInterpreter));
            });
        }


        public void StartExecuting(DateTime startTime)
        {
            var currentDateTime = DateTime.Now;

            if (startTime == null || startTime < currentDateTime)
                throw new Exception("Дата старта выполнения сценария меньше текущей");

            timer = new Timer((startTime - currentDateTime).TotalMilliseconds);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            foreach (var eventExecuter in EventExecuters)
            {
                eventExecuter.Execute();
            }
        }
    }
}
