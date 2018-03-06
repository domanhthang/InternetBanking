using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Domain.Money
{
	public static class CreateMoney
	{
		public static IMoney Create(string value)
		{
			return new VND(value);
		}
	}
}
