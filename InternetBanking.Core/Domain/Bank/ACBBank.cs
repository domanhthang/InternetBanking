using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Domain.Bank
{
	public class ACBBank : IAccountBank
	{
		private readonly string _id;

		public ACBBank(string id)
		{
			_id = id;
		}

		public string Name => "ACBBank";
		public string ID => this._id;

		public void SendTo(IAccountBank accountBank)
		{

		}
	}
}
