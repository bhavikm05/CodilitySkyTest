using NUnit.Framework;
using System.Collections.Generic;

namespace LeastUniqueElement
{
    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int min = int.MaxValue;
            int current;
            int next;
            bool exists = false;
            for (int index1 = 0; index1 < A.Length; index1++)
            {
                current = System.Math.Abs(A[index1]);
                next = current + 1;
                for (int index2 = 0; index2 < A.Length; index2++)
                {
                    if (next == System.Math.Abs(A[index2]))
                    {
                        exists = true;
                    }
                }
                if (!exists)
                {
                    if (min > next)
                        min = next;
                }
                exists = false;
            }             
            if (min == int.MaxValue)
                return 0;
            else
                return min;
        }
    }

    [Ignore("Avoid")]
    [TestFixture()]
    public class SolutionTests
    {

        [Test()]
        public void Test2()
        {
            Solution instance = new Solution();
            int[] A = new int[6];
            A[0] = 1;
            A[1] = 3;
            A[2] = 6;
            A[3] = 4;
            A[4] = 1;
            A[5] = 2;
            int min = instance.solution(A);
            Assert.AreEqual(5, min);
        }

        [Test()]
        public void TestNEG()
        {
            Solution instance = new Solution();
            int[] A = new int[6];
            A[0] = -1;
            A[1] = -3;
            A[2] = 1;            
            int min = instance.solution(A);
            Assert.AreEqual(2, min);
        }

        [Test()]
        public void TestOnlyNEG()
        {
            Solution instance = new Solution();
            int[] A = new int[6];
            A[0] = -1;
            A[1] = -3;         
            int min = instance.solution(A);
            Assert.AreEqual(0, min);
        }

    }


}
