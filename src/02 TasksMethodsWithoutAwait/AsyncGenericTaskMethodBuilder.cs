using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    public struct AsyncTaskMethodBuilder<T>
    {
        public Task<T> Task => null;

#pragma warning disable CS0436 // Type conflicts with imported type
        public static AsyncTaskMethodBuilder<T> Create()
        {
            Console.WriteLine("Create called");
            return new AsyncTaskMethodBuilder<T>();
        }

        public void SetException(Exception e)
        {
            Console.WriteLine("SetException called");
        }

        public void SetResult(T result)
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
#pragma warning restore CS0436 // Type conflicts with imported type
    }
}