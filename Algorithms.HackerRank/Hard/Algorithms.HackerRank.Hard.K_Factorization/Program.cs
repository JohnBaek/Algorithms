using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Algorithms.HackerRank.Hard.K_Factorization
{
    /// <summary>
    /// Resolve
    /// </summary>
    class Result
    {

        /*
        * Complete the 'kFactorization' function below.
        *
        * The function is expected to return an INTEGER_ARRAY.
        * The function accepts following parameters:
        *  1. INTEGER n
        *  2. INTEGER_ARRAY A
        */
        public static List<int> kFactorization(int n, List<int> A)
        {

        }

    }

    /// <summary>
    /// Solution
    /// </summary>
    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            List<int> result = Result.kFactorization(n, A);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}


