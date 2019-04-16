using System;

namespace BusinessLogic
{
    public interface IScenarioActor
    {
        int ScenarioId { get; set; }

        void StartExecuting(DateTime startTime);
    }
}
