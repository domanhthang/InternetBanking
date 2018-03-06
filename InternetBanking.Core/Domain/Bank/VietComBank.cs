using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Core.Domain.Bank
{
	public class VietComBank : IAccountBank
	{
		private readonly string _id;

		public VietComBank(string id)
		{
			_id = id;
		}

		public string Name => "VietComBank";
		public string ID => this._id;

		public void SendTo(IAccountBank accountBank)
		{
			
		}
	}
}
