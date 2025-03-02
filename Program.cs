using Events;

namespace EventsDelegates
{
    class Program
    {
        // This is main method 
        public static void Main()
        {
            // Creating Object(instance) of ProcessBusinessLogic Class
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            // Subscribing the event handler to the event
            bl.ProcessCompleted += bl_ProcessCompleted;

            // Calling StartProcess()
            bl.StartProcess();
        }

        // Event handler method that gets executed when the event is completed
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked");
        }
    }
}