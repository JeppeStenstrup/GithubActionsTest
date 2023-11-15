using GithubActionsTest;

namespace Tests
{
    public class Tests
    {
        private DemoClass demo;
        [SetUp]
        public void Setup()
        {
            demo = new();
        }

        [Test]
        public void Test1()
        {
            var result1 = demo.Add(1, 1);
            Assert.That(result1, Is.EqualTo(2));

            var result2 = demo.Add(1, 1);
            Assert.That(result2, Is.EqualTo(5));
        }
    }
}