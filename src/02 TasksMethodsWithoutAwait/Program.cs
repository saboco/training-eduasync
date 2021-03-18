using System.Threading.Tasks;

namespace TrainingEduasync
{
    class Program
    {
        static void Main(string[] _)
        {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            DoNothingAsync();
            DoNothingAsync(7);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private static async Task DoNothingAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {

        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private static async Task<int> DoNothingAsync(int i)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            return i;
        }
    }
}
