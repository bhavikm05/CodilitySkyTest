using NUnit.Framework;

namespace Task3
{
    class Solution
    {
        public int solution(int A, int B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return 3;
        }
    }

    [TestFixture()]
    public class Task3Tests
    {
       
        [Test()]
        public void Test3()
        {
            Solution instance = new Solution();
            int A = 0, B = 0;            
            int P = instance.solution(A, B);
            Assert.AreEqual(P, 3);                      
        }
       
    }


}
