using System;
using System.Collections.Generic;

namespace BusinessLogic.Scenarios
{
    public class ScenarioActor : IScenario
    {
        public int ScenarioId { get; set; }

        List<IEventExecuter> EventExecuters { get; } = new List<IEventExecuter>();


        public void StartExecuting(DateTime startTime)
        {
            foreach (var eventExecuter in EventExecuters)
            {
                eventExecuter.Execute();
            }
        }
    }
}
