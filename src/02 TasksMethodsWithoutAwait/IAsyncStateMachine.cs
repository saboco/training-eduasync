namespace System.Runtime.CompilerServices
{
    public interface IAsyncStateMachine
    {
        void MoveNext();

#pragma warning disable CS0436 // Type conflicts with imported type
        void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
#pragma warning restore CS0436 // Type conflicts with imported type
    }
}