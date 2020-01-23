namespace TrainingEduasync
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DoNothingAsync();
        }
        
        // Exactly the same method as in eduasyn, we get the same warning about the method missing an await operator
        // but we do not have the compilation error
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private static async void DoNothingAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
        }
    }
}
