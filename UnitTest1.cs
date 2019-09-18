using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject8
{
    public class UnitTest1
    {
        MyObject obj1 = new MyObject();
        MyObject obj2 = new MyObject();

        [Theory]
        [InlineData(1,2)]
        [InlineData(2, 3)]
        public void Test1(int x, int y)
        {
            Assert.Empty("a");
        }



        [Theory]
        [InlineData("abc")]
        [InlineData("def")]
        public void Test2(string x)
        {
            Assert.Equal("abc", x);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void Test3(IEnumerable<int> input, IEnumerable<int> expected)
        {

        }
    }


    public class MyObject
    {

    }
}
