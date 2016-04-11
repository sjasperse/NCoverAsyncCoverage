using System.Threading.Tasks;
using NUnit.Framework;

namespace NCoverAsyncCoverage
{
    public class Widget
    {
        public async Task<bool> Get()
        {
            return await Task.FromResult(true);
        }
    }

    [TestFixture]
    public class Test
    {
        [Test]
        public void GetReturnsTrue()
        {
            var widget = new Widget();

            Assert.IsTrue(widget.Get().Result);
        }
    }
}