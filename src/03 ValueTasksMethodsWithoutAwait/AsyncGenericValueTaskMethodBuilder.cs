namespace System.Runtime.CompilerServices
{
    using System.Threading.Tasks;

    public struct AsyncValueTaskMethodBuilder<T>
    {
        /// <summary>The <see cref="AsyncTaskMethodBuilder"/> to which most operations are delegated.</summary>
        private AsyncTaskMethodBuilder _methodBuilder; // mutable struct; do not make it readonly
        /// <summary>true if completed synchronously and successfully; otherwise, false.</summary>
        private bool _haveResult;
        /// <summary>true if the builder should be used for setting/getting the result; otherwise, false.</summary>
        private bool _useBuilder;

        public static AsyncValueTaskMethodBuilder<T> Create()
        {
            Console.WriteLine("Create called");
            return new AsyncValueTaskMethodBuilder<T>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
        {
            Console.WriteLine("Start called");
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            Console.WriteLine("SetStateMachine called");
        }

        public void SetStateMachine()
        {
            Console.WriteLine("SetStateMachine called");
        }

        public void SetResult(T result)
        {
            Console.WriteLine("SetResult called");
        }

        public void SetException(Exception e)
        {
            Console.WriteLine("SetException called");
        }

        public ValueTask<T> Task => new ValueTask<T>(null);

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
             where TAwaiter : INotifyCompletion
             where TStateMachine : IAsyncStateMachine
        {
            Console.WriteLine("AwaitOnCompleted called");
        }

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
           where TAwaiter : ICriticalNotifyCompletion
           where TStateMachine : IAsyncStateMachine
        {
            Console.WriteLine("AwaitUnsafeOnCompleted called");
        }
    }
}