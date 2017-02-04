using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaWithFractionCollection
{
    internal class Program
    {
        private static void Main()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            var fractionList = new List<Fraction>();

            for (var i = 0; i < 100; i++)
            {
                fractionList.Add(new Fraction(random.Next(1,10), random.Next(1,100)));
            }

            Console.WriteLine(string.Join(" ", fractionList.Where(x => x.Numerator % x.Denominator == 0).Select(x => x.Numerator / x.Denominator)));
            Console.ReadKey();
        }
    }
}
