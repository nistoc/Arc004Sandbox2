using BusinessLogic;
using Devices;
using System;
using System.Threading;
using BusinessLogic.Scenarios;
using Domains;

namespace Arc004ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var eventSourcesProvider = new EventSourcesProvider();


            var eventRecorderFabrika = new EventRecorderFabrika(eventSourcesProvider);
            var eventRecorder = eventRecorderFabrika.GetRecorder();
            eventRecorder.StartRecording();

            //training
            GenerateFackeEvents(eventSourcesProvider);
            var deviceEventTimers = eventRecorder.StopRecording();



            // somehow save - Save(deviceEventTimers);



            // somehow restore



            //replay

            var concreteScenarioActor = new ConcreteScenarioActor(deviceEventTimers, new DeviceCommandInterpreter());
            concreteScenarioActor.StartExecuting(DateTime.Now.AddSeconds(7));
            Console.ReadLine();
        }

        private static void GenerateFackeEvents(EventSourcesProvider eventSourcesProvider)
        {
            var eventMock = new EventSourcesProviderMock();

            eventSourcesProvider.RegisterEvent(eventMock.GenerateEvent_Lamp1_Enable());
            Thread.Sleep(7 * 1000);

            eventSourcesProvider.RegisterEvent(eventMock.GenerateEvent_Lamp2_Enable());
            Thread.Sleep(3 * 1000);

            eventSourcesProvider.RegisterEvent(eventMock.GenerateEvent_Lamp2_Disable());
            Thread.Sleep(5 * 1000);
            eventSourcesProvider.RegisterEvent(eventMock.GenerateEvent_Lamp1_Enable());
        }
    }
}
