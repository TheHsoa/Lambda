using System;

namespace LambdaWithFractionCollection
{
    internal class Fraction
    {
        public long Numerator { get; }
        public long Denominator { get; }

        public Fraction(long numerator, long denominator)
        {
            if(denominator == 0) throw new DivideByZeroException("Denominator can't be zero");

            Numerator = numerator;
            Denominator = denominator;
        }
    }
}
