using System;

namespace Survey.Persistance.Common
{
    public interface ITransactionManager
    {
        #region Public Methods and Operators

        IDisposable BeginTransaction();

        void CommitTransaction(IDisposable transactionToken);

        void RollbackTransaction(IDisposable transactionToken);

        #endregion
    }
}