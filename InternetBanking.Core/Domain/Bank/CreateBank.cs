using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Domain.Bank
{
	public static class CreateBank
	{
		public static IAccountBank Create(string name, string id)
		{
			switch (name)
			{
				case "vtb":
					return new VietinBank(id);
				case "vcb":
					return new VietComBank(id);
				case "acb":
					return new ACBBank(id);
				default:
					return null;
			}
		}
	}
}
