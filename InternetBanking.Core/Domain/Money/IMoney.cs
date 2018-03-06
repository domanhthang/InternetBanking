using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Core.Domain.Money
{
    public interface IMoney
    {
		string Name { get;}
		string Value { get; set; }
	}
}
