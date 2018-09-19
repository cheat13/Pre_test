using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using myApi.Controllers;

namespace myApi.test
{
    public class test
    {
        [Theory(DisplayName ="บวกเลข 2 ตัวถูกต้อง")]
        [InlineData(1,2,3)]
        [InlineData(1,0,1)]
        public void testAdd(int p1 ,int p2 ,double expected)
        {
            var test = new calc();
            var result = test.add(p1,p2);
            Assert.Equal(expected,result);
        }

        [Theory(DisplayName = "ลบเลข 2 ตัวถูกต้อง")]
        [InlineData(1, 2, -1)]
        [InlineData(1, 0, 1)]
        public void testMinus(int p1, int p2, double expected)
        {
            var test = new calc();
            var result = test.minus(p1, p2);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "คูณเลข 2 ตัวถูกต้อง")]
        [InlineData(1, 2, 2)]
        [InlineData(1, 0, 0)]
        [InlineData(-1, -1, 1)]
        public void testMultiply(int p1, int p2, double expected)
        {
            var test = new calc();
            var result = test.multiply(p1, p2);
            Assert.Equal(expected, result);
        }

        [Theory(DisplayName = "หารเลข 2 ตัวถูกต้อง")]
        [InlineData(1, 2, 0.5)]
        [InlineData(4, 2, 2)]
        [InlineData(0, 2, 0)]
        public void testDivide(int p1, int p2, double expected)
        {
            var test = new calc();
            var result = test.divide(p1, p2);
            Assert.Equal(expected, result);
        }



    }
}
