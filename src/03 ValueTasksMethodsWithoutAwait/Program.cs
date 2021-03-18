using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace TrainingEduasync
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = DoNothingAsync();
            Console.WriteLine(a);
        }

        //#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async static ValueTask<int> DoNothingAsync()
        //#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {   
            return 3;
        }
    }
}
