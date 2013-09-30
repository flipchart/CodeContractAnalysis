using ContractCodeAnalysis.Implementations;
using NUnit.Framework;

namespace ContractCodeAnalysis.Tests
{
    [TestFixture]
    public class SomeEventDispatcherFixture
    {
        [Test]
        public void CanDispatch()
        {
            //arrange
            var evt = new SomeEvent("Test Event");
            var dispatcher = new SomeEventDispatcher();

            //act
            dispatcher.Dispatch(evt);

            //assert

        }
    }
}
