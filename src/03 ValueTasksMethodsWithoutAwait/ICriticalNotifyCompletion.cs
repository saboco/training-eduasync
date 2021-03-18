namespace System.Runtime.CompilerServices
{
#pragma warning disable CS0436 // Type conflicts with imported type
    public interface ICriticalNotifyCompletion : INotifyCompletion
#pragma warning restore CS0436 // Type conflicts with imported type
    {
        [System.Security.SecurityCritical]
        void UnsafeOnCompleted(Action continuation);
    }
}