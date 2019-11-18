namespace Domain.Customers
{
    using System;
    using Domain.Accounts;
    using Domain.ValueObjects;

    public class Customer : ICustomer
    {
        public Customer()
        {
            Accounts = new AccountCollection();
        }

        public ExternalUserId ExternalUserId { get; protected set; }

        public Guid Id { get; protected set; }

        public Name Name { get; protected set; }

        public SSN SSN { get; protected set; }

        public AccountCollection Accounts { get; protected set; }

        public void Register(IAccount account)
        {
            Accounts ??= new AccountCollection();
            Accounts.Add(account.Id);
        }
    }
}
