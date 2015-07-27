using NUnit.Framework;

namespace Task4
{
    class Solution
    {        
        public int solution(int[] A)
        {
            
            return -1;
        }
    }

    [TestFixture()]
    public class Task4Tests
    {
       
        [Test()]
        public void Test1()
        {
            Solution instance = new Solution();
            int[] A = new int[1];
            A[0] = -1;            
            int P = instance.solution(A);
            Assert.AreEqual(P, 1);                      
        }
       
    }


}
