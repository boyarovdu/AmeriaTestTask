using System;
using System.Data.Entity;
using Microsoft.Practices.ServiceLocation;
using Survey.Persistance.Common;

namespace Survey.Persistance.Impl
{
    public class TransactionManager : ITransactionManager
    {
        public TransactionManager()
        {
            var context = ServiceLocator.Current.GetInstance<IContext>();
            Database = context.Database;
        }

        protected Database Database { get; set; }

        public IDisposable BeginTransaction()
        {
            return Database.BeginTransaction();
        }

        public void CommitTransaction(IDisposable transactionToken)
        {
            var transaction = transactionToken as DbContextTransaction;
            if (transaction != null) transaction.Commit();
        }

        public void RollbackTransaction(IDisposable transactionToken)
        {
            var transaction = transactionToken as DbContextTransaction;
            if (transaction != null) transaction.Rollback();
        }
    }
}
