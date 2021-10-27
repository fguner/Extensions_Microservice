using MathAPI.Infrastructure;
using MathAPI.Models;
using System;

namespace MathAPI.Services
{
    public class MathService : IMathService
    {
        MathDTO MathData;
        public Boolean GetIsPrime(int number)
        {
            for (int i = 2; i < number-1; i++)
            {
                if(number%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
