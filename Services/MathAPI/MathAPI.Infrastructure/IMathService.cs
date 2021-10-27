using MathAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathAPI.Infrastructure
{
    public interface IMathService
    {
        public Boolean GetIsPrime(int number);
    }
}
