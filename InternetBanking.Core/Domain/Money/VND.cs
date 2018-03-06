using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Domain.Money
{
	public class VND : IMoney
	{
		public VND(string value)
		{
			this.Value = value;
		}
		public string Name => "VND";
		public string Value { get; set; }
	}
}
