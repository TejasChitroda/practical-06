// namespace EventsDelegates
// {
//     // Creating delegate to handle event
//     public delegate void ProcessCompletedEventHandler();
//     class ProcessBusinessLogic
//     {

//         // Creating event and binding it with delegate
//         public event ProcessCompletedEventHandler ProcessCompleted;
//         // method to start the process, which will later trigger the event
//         public void StartProcess()
//         {
//             Console.WriteLine("Process Started!");
//             // method invocation
//             OnProcessCompleted();
//         }
//         protected virtual void OnProcessCompleted()
//         {
//             // Checking if there are any subscribers before invoking the event
//             ProcessCompleted?.Invoke();
//         }
//     }
// }



namespace Events
{

    //ProcessCompletedEventHandler : it is for handling events
    public delegate void ProcessCompletedEventHandler();
    class ProcessBusinessLogic
    {
        // we are creating events and binding with delegate (it may be null)
        public event ProcessCompletedEventHandler? ProcessCompleted;
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted()
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }

}