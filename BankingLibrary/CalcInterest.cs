using System;

namespace BankingLibrary
{
    public class CalcInterest : ICalcInterest
    {
        public int Calculate(int principle, int RateofInterest, int years)
        {
            int SimpleInterest = (principle * RateofInterest * years) / 100;
            return SimpleInterest;
        }
    }
}
