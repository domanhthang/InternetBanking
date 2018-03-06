using InternetBanking.Core.Domain.Bank;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Core.Domain.User
{
    public class User
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public List<IAccountBank> AccountBanks { get;}
    }
}
