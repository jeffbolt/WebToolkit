using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace WebToolkit
{
    public static class MathHelper
    {
        public static int RandomNumber(int MinNumber, int MaxNumber)
        {
            Random r = new Random(GetCsprng());
            //Randomize();
            return r.Next(MinNumber, MaxNumber);
        }

        private static int GetCsprng()
        {
            using (var csprng = new RNGCryptoServiceProvider())
            {
                return csprng.GetHashCode();
            }
        }
    }
}