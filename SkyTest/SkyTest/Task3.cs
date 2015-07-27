using NUnit.Framework;

namespace Task3
{
    class Solution
    {        
        public int solution(int[] A)
        {
            
            return -1;
        }
    }

    [TestFixture()]
    public class SolutionTests
    {
       
        [Test()]
        public void Test1()
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
            //int P = instance.solution(A);
            //Assert.AreEqual(P, -1);
        }

       

    }


}
