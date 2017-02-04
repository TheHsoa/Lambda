using System;
using System.Linq;

namespace FirstLinqUsing
{
    internal class Program
    {
        private static void Main()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            var array = new int[10];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }

            Console.WriteLine(string.Join(" ", array.Where(x => x > 5 && x % 2 == 0).OrderBy(x => x)));

            Console.ReadKey();
        }
    }
}
