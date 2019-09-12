﻿using System;
using System.Data;
using DbUp.Engine.Output;
using DbUp.Engine.Transactions;
using DbUp.Tests.TestInfrastructure;
using NSubstitute;
using Shouldly;
using Xunit;

#pragma warning disable 618

namespace DbUp.Tests.Engine
{
    public class TransactionTests
    {
        [Fact]
        public void OnlyOneTransactionIsOpenedAtATimeWithTransactionPerScriptStrategy()
        {

/* Unmerged change from project 'dbup-tests (netcoreapp2.0)'
Before:
            var connectionFactory = new TransactionCountingConnectionFactory();
            
            var upgradeEngine = DeployChanges.To
After:
            var connectionFactory = new TransactionCountingConnectionFactory();

            var upgradeEngine = DeployChanges.To
*/
            var connectionFactory = new TransactionCountingConnectionFactory();

            var upgradeEngine = DeployChanges.To
                .SqlDatabase("")
                .OverrideConnectionFactory(connectionFactory)
                .WithScript("testscript1", "SELECT 1")
                .WithScript("testscript2", "SELECT 1")
                .WithTransactionPerScript()
                .Build();

            var result = upgradeEngine.PerformUpgrade();
            result.Error.ShouldBeNull();
            result.Successful.ShouldBeTrue();


            connectionFactory.TransactionWasOpened.ShouldBeTrue("BeginTransaction was never called");
        }

        private class TransactionCountingConnectionFactory : IConnectionFactory
        {
            private int transactionCount = 0;

            public bool TransactionWasOpened { get; private set; }

            public IDbConnection CreateConnection(IUpgradeLog upgradeLog, DatabaseConnectionManager databaseConnectionManager)
            {
                var conn = Substitute.For<IDbConnection>();
                conn.BeginTransaction().ReturnsForAnyArgs(c =>
                {
                    TransactionWasOpened = true;

                    if (transactionCount > 0)
                        throw new Exception("Test failed as multiple transaction were opened");

                    transactionCount++;
                    var trn = Substitute.For<IDbTransaction>();
                    trn.When(_ => _.Dispose()).Do(_ => transactionCount--);
                    return trn;
                });
                return conn;
            }
        }


    }
}