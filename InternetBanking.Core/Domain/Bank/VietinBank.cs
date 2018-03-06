using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Core.Domain.Bank
{
	public class VietinBank : IAccountBank
	{
		private readonly string _id;

		public VietinBank(string id)
		{
			_id = id;
		}

		public string Name => "VietinBank";
		public string ID => this._id;

		public void SendTo(IAccountBank accountBank)
		{
			
		}
	}
}
