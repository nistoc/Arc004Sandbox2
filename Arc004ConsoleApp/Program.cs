using BusinessLogic;
using Contracts;
using Devices;
using System;
using System.Threading;

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
            GenerateFackeEvents(eventSourcesProvider);
            eventRecorder.StopRecording();


        }

        private static void GenerateFackeEvents(EventSourcesProvider eventSourcesProvider)
        {
            var eventMock = new EventSourcesProviderMock();

            eventSourcesProvider.RegisterEvent(eventMock.GenerateEvent_Lamp1_Enable());
            Thread.Sleep(7 * 1000);

            eventSourcesProvider.RegisterEvent(eventMock.GenerateEvent_Lamp2_Enable());
            Thread.Sleep(20 * 1000);

            eventSourcesProvider.RegisterEvent(eventMock.GenerateEvent_Lamp2_Disable());
            Thread.Sleep(5 * 1000);
            eventSourcesProvider.RegisterEvent(eventMock.GenerateEvent_Lamp1_Enable());
        }
    }
}
