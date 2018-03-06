using InternetBanking.Core.Domain.Bank;
using InternetBanking.Core.Domain.Money;
using InternetBanking.Core.Domain.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Service
{
    public class TransferMoney
    {
		public Guid Id { get; set; }
		public IAccountBank sender { get; set; }
		public IAccountBank receiver { get; set; }
		public IMoney Value { get; set; }
		public User User { get; set; }

		public void Transfer()
		{

		}

    }
}
