namespace System.Runtime.CompilerServices
{
    public struct AsyncVoidMethodBuilder
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        public static AsyncVoidMethodBuilder Create()
        {
            Console.WriteLine("Create called");
            return new AsyncVoidMethodBuilder();
        }

        public void SetException(Exception e)
        {
            Console.WriteLine("SetException called");
        }

        public void SetResult()
        {
            Console.WriteLine("SetResult called");
        }

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion
            where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            Console.WriteLine("AwaitOnCompleted called");
        }

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion
            where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            Console.WriteLine("AwaitUnsafeOnCompleted called");
        }

        public void Start<TStateMachine>(ref TStateMachine stateMachine)
            where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            Console.WriteLine("Start called");
        }

        public void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
        {
            Console.WriteLine("SetStateMachine called");
        }
    }

    public interface INotifyCompletion
    {
        void OnCompleted(Action continuation);
    }

    public interface IAsyncStateMachine
    {
        void MoveNext();

        void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    public interface ICriticalNotifyCompletion : INotifyCompletion
#pragma warning restore CS0436 // Type conflicts with imported type
    {
        [System.Security.SecurityCritical]
        void UnsafeOnCompleted(Action continuation);
    }
}