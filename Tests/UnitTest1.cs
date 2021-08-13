using System;
using Xunit;
using CalcLib;

/*

Show examples of Facts and Theories being used.

*/


namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            RecursiveCalc calc = new RecursiveCalc();

            Assert.Throws<DivideByZeroException>(() => calc.PrimeCheckRec(9, 1));
        }


        // Create Unit Tests using xUnit for the methods FibonnacciRec, FactorialRec and PrimeCheckRec.
        
        [Fact]
        public void test2()
        {
        RecursiveCalc fibcheck = new RecursiveCalc();
        fibcheck.FibonacciRec(2,4,8); 
        Console.WriteLine(fibcheck);

        // demonstrating the concept, not sure what the output would be
        Assert.Equal(6,fibcheck.FibonacciRec(2,4,8));
        }

        [Fact]

        public void test3()
        {
        RecursiveCalc factcheck = new RecursiveCalc();
        factcheck.FactorialRec(30,10);
        // demonstrating the concept, not sure what the output would be
        Assert.Equal(30,factcheck.FactorialRec(30,10));
        }

        [Theory]

        public void test4()
        {
        RecursiveCalc PrimeCheckRec = new RecursiveCalc();
        PrimeCheckRec.PrimeCheckRec(30,10);
        string values = Console.ReadLine();
        // demonstrating the concept, not sure what the output would be
        Assert.Equal("true", values);
        }


        public void test5()
        {
            RecursiveCalc calc = new RecursiveCalc();

            Assert.Throws<DivideByZeroException>(() => calc.PrimeCheckRec(5,0));
        }
    }

}
