using FizzBuzz.Rule.Collections;
using FizzBuzz.Rule.Interface;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzManagementTest
    {
        [Test]
        public void GetText_ShouldReturn1_WhenInput1()
        {
            IRuleCollection collection = new DefaultRuleCollection();
            var management = new FizzBuzzManagement(collection);

            string actual = management.GetText(1);

            Assert.AreEqual("1", actual);
        }

        [Test]
        public void GetText_ShouldReturn2_WhenInput2()
        {
            IRuleCollection collection = new DefaultRuleCollection();
            var management = new FizzBuzzManagement(collection);

            string actual = management.GetText(2);

            Assert.AreEqual("2", actual);
        }

        [Test]
        public void GetText_ShouldReturnFizz_WhenInput3()
        {
            IRuleCollection collection = new DefaultRuleCollection();
            var management = new FizzBuzzManagement(collection);

            string actual = management.GetText(3);

            Assert.AreEqual("Fizz", actual);
        }

        [Test]
        public void GetText_ShouldReturn4_WhenInput4()
        {
            IRuleCollection collection = new DefaultRuleCollection();
            var management = new FizzBuzzManagement(collection);

            string actual = management.GetText(4);

            Assert.AreEqual("4", actual);
        }

        [Test]
        public void GetText_ShouldReturnBuzz_WhenInput5()
        {
            IRuleCollection collection = new DefaultRuleCollection();
            var management = new FizzBuzzManagement(collection);

            string actual = management.GetText(5);

            Assert.AreEqual("Buzz", actual);
        }

        [Test]
        public void GetText_ShouldReturnFizz_WhenInput6()
        {
            IRuleCollection collection = new DefaultRuleCollection();
            var management = new FizzBuzzManagement(collection);

            string actual = management.GetText(6);

            Assert.AreEqual("Fizz", actual);
        }

        [Test]
        public void GetText_ShouldReturnFizz_WhenInput9()
        {
            IRuleCollection collection = new DefaultRuleCollection();
            var management = new FizzBuzzManagement(collection);

            string actual = management.GetText(9);

            Assert.AreEqual("Fizz", actual);
        }

        [Test]
        public void GetText_ShouldReturnBuzz_WhenInput10()
        {
            IRuleCollection collection = new DefaultRuleCollection();
            var management = new FizzBuzzManagement(collection);

            string actual = management.GetText(10);

            Assert.AreEqual("Buzz", actual);
        }

        [Test]
        public void GetText_ShouldReturnFizzBuzz_WhenInput15()
        {
            IRuleCollection collection = new DefaultRuleCollection();
            var management = new FizzBuzzManagement(collection);

            string actual = management.GetText(15);

            Assert.AreEqual("FizzBuzz", actual);
        }
    }
}