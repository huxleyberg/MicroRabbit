using System;
using System.Collections.Generic;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Banking.Data.Context;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _cts;
        public AccountRepository(BankingDbContext bankingDbContext)
        {
            _cts = bankingDbContext;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _cts.Accounts;
        }
    }
}
