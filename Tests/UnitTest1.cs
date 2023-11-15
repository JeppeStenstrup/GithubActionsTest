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
        public void PassingTest()
        {
            var result = demo.Add(1, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void FailingTest()
        {
            var result = demo.Add(1, 1);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}