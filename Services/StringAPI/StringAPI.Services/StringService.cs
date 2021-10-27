using StringAPI.Infrastructure;
using StringAPI.Models;
using System;

namespace StringAPI.Services
{
    public class StringService : IStringService
    {
        public StringDTO StringData { get; set; }
        public int GetLenghtText(string text)
        {
            return text.Length;
        }
    }
}
