using System.Diagnostics.Contracts;
using ContractCodeAnalysis.Interfaces;

namespace ContractCodeAnalysis.Implementations
{
    public class SomeEvent : IEvent
    {
        public SomeEvent(string name)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(name));

            Name = name;
        }

        [ContractInvariantMethod]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Required for code contracts.")]
        private void ObjectInvariant()
        {
            Contract.Invariant(!string.IsNullOrWhiteSpace(Name));
        }

        public string Name { get; private set; }
    }
}
