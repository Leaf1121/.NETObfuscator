using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAssembly.Utils
{
    class RandomString
    {
        private static Random random = new Random();
        private static Random length = new Random();

        public string GetRandom()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            return new string(Enumerable.Repeat(chars, length.Next(5, 20)).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
