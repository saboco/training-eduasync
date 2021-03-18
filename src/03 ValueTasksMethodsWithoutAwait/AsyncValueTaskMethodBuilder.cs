namespace System.Runtime.CompilerServices
{
    using System.Threading.Tasks;

    public struct AsyncValueTaskMethodBuilder
    {
        public ValueTask Task => new ValueTask(null);

        void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
        {
            Console.WriteLine("SetStateMachine called");
        }

        public static AsyncValueTaskMethodBuilder Create()
        {
            Console.WriteLine("Create called");
            return new AsyncValueTaskMethodBuilder();
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
    }
}