using System;
using System.Threading.Tasks;

namespace _04_ValueTasksMethodsWithAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = DoNothingAsync();
            Console.WriteLine(a);
        }

        private async static ValueTask<int> DoNothingAsync()
        {
            var t = Task.FromResult(3);
            return await t;
        }
    }
}
