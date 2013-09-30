using System;
using ContractCodeAnalysis.Interfaces;

namespace ContractCodeAnalysis.Implementations
{
    public sealed class SomeEventDispatcher : Dispatcher<SomeEvent>
    {
        public override void Dispatch(SomeEvent evt)
        {
            Console.WriteLine("SomeEvent named '{0}' was dispatched!", evt.Name);
        }
    }
}
