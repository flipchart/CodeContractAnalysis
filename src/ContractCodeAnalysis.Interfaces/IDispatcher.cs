using System;
using System.Diagnostics.Contracts;

namespace ContractCodeAnalysis.Interfaces
{
    public interface IEvent { }

    [ContractClass(typeof(IDispatcherContract))]
    public interface IDispatcher
    {
        void Dispatch(IEvent evt);
    }

    [ContractClass(typeof(IDispatcherContract<>))]
    public interface IDispatcher<TEvent> : IDispatcher where TEvent : IEvent
    {
        void Dispatch(TEvent evt);
    }

    public abstract class Dispatcher<TEvent> : IDispatcher<TEvent> where TEvent : IEvent
    {
        #region IDispatcher<TEvent> Members

        public abstract void Dispatch(TEvent evt);

        #endregion

        #region IDispatcher Members

        public void Dispatch(IEvent evt)
        {
            Dispatch((TEvent)evt);
        }

        #endregion
    }

    #region Contracts

    [ContractClassFor(typeof(IDispatcher))]
    abstract class IDispatcherContract : IDispatcher
    {
        #region IDispatcher Members

        public void Dispatch(IEvent evt)
        {
            Contract.Requires(evt != null);

            throw new NotImplementedException();
        }

        #endregion
    }

    [ContractClassFor(typeof(IDispatcher<>))]
    abstract class IDispatcherContract<TEvent> : IDispatcher<TEvent> where TEvent : IEvent
    {
        #region IDispatcher<TEvent> Members

        public void Dispatch(TEvent evt)
        {
            Contract.Requires(evt != null);

            throw new NotImplementedException();
        }

        #endregion

        #region IDispatcher Members

        public void Dispatch(IEvent evt)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    #endregion
}
