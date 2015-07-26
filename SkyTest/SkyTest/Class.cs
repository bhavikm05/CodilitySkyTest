using NUnit.Framework;

namespace SkyTest
{
    class Solution
    {
        
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if(A.Length == 0)
                return 0;
            int indexLeft;
            int totalLeft = 0;
            for (indexLeft = 0; indexLeft < A.Length; indexLeft++)
            {
                totalLeft += A[indexLeft];
                int indexRight;
                int totalRight = 0;
                for (indexRight = indexLeft; indexRight < A.Length; indexRight++)
                {
                    totalRight += A[indexRight];                    
                }
                if (totalLeft == totalRight)
                    return indexLeft;
            }
            return -1;
        }
    }

    [TestFixture()]
    public class SolutionTests
    {
       
        [Test()]
        public void Test8Elements()
        {
            Solution instance = new Solution();
            int[] A = new int[8];
            A[0] = -1;
            A[1] = 3;
            A[2] = -4;
            A[3] = 5;
            A[4] = 1;
            A[5] = -6;
            A[6] = 2;
            A[7] = 1;
            int P = instance.solution(A);
            Assert.AreEqual(P, 1);
            //int P = instance.solution(A);
            //Assert.AreEqual(P, 3);
            //int P = instance.solution(A);
            //Assert.AreEqual(P, 7);
        }

        [Test()]
        public void TestZeroElements()
        {
            Solution instance = new Solution();
            int[] array = new int[] { };
            int result = instance.solution(array);
            Assert.AreEqual(result, 0);
        }
    }


}
