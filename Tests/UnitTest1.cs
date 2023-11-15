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
            var result = demo.Add(1, 1);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}