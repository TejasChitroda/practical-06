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