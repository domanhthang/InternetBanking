using System;
using System.Collections.Generic;
using System.Text;

namespace InternetBanking.Core.Domain.Bank
{
    public interface IAccountBank
    {
		string Name { get;}
		string ID { get;}
		void SendTo(IAccountBank accountBank);
    }
}
