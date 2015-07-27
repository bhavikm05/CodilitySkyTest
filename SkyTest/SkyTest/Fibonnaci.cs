using NUnit.Framework;
using System.Collections.Generic;

namespace Fibonnaci
{
    class Solution
    {
        public int Fibonnaci(int n)
        {
            System.Collections.Generic.Dictionary<int, int> fibonnaci = new Dictionary<int, int>();
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int index;
                for (index = 0; index <= n; index ++)
                {
                    if(index == 0)
                        fibonnaci.Add(index, 0);
                    if (index == 1)
                        fibonnaci.Add(index, 1);
                    if (index >= 2)
                        fibonnaci[index] = fibonnaci[index - 1] + fibonnaci[index - 2];                    
                }
            }
            return fibonnaci[n];
        }
    }
    [Ignore("Avoid")]
    [TestFixture()]
    public class SolutionTests
    {

        [Test()]
        public void Test1()
        {
            Solution instance = new Solution();
            Assert.AreEqual(instance.Fibonnaci(0), 0);
            Assert.AreEqual(instance.Fibonnaci(1), 1);
            Assert.AreEqual(instance.Fibonnaci(2), 1);
            Assert.AreEqual(instance.Fibonnaci(3), 2);
            Assert.AreEqual(instance.Fibonnaci(4), 3);
            Assert.AreEqual(instance.Fibonnaci(5), 5);
            Assert.AreEqual(instance.Fibonnaci(6), 8);
            Assert.AreEqual(instance.Fibonnaci(7), 13);
            Assert.AreEqual(instance.Fibonnaci(8), 21);            
            Assert.AreEqual(instance.Fibonnaci(9), 34);            
        }


    }


}
