using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    [TestFixture]
    public static class Concatenate
    {
            public static string ConcatenateString(string str1, string str2)
            {
                if (str1 == null || str2 == null)
                {
                    throw new NullReferenceException("Input strings cannot be null");
                }
                return str1 + str2;
            }
    }
}
