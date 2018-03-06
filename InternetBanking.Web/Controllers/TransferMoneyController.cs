using InternetBanking.Core.Domain.Bank;
using InternetBanking.Core.Domain.Money;
using InternetBanking.Core.Domain.User;
using InternetBanking.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternetBanking.Web.Controllers
{
    public class TransferMoneyController : Controller
    {
		public ActionResult ChooseBank()
		{
			return View();
		}

		[HttpPost, ActionName("ChooseBank")]
		public ActionResult ChooseBankConfirm(FormCollection form)
		{
			string banksender = form["banksender"];
			string bankreceive = form["bankrecieve"];
			//List<string> banks = new List<string>() { banksender, bankreceive };
			return RedirectToAction("Transfer", new {sender= banksender, receive = bankreceive });
		}

		// GET: TransferMoney
		[HttpGet]
        public ActionResult Transfer(string sender, string receive)
        {
			ViewData["sender"] = sender;
			ViewData["receive"] = receive;
			return View();
        }

		[HttpPost, ActionName("Transfer")]
		public ActionResult TransferConfirm(FormCollection form)
		{
			var payment = new TransferMoney();
			payment.sender = CreateBank.Create(form["sendername"], form["senderaccount"]);
			payment.receiver = CreateBank.Create(form["receivename"], form["receiveaccoount"]);
			payment.Value = CreateMoney.Create(form["sendamount"]);
			payment.User = new User { Email = form["email"] };

			payment.Transfer();
			return RedirectToAction("Index", "Home");
		}

		
    }
}