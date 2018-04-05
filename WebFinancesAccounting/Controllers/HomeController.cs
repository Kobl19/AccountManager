using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFinancesAccounting.Models.Repositories.Interfaces;
using WebFinancesAccounting.ViewModels;

namespace WebFinancesAccounting.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;
        public HomeController(IRepository repository)
        {
            this._repository = repository;
        }
        public ActionResult Authorization()
        {
            AuthorizationViewModel model = new AuthorizationViewModel();
            model.Users=_repository.AllUsers().ToList();
            return View(model);
        }
        public ActionResult Index(int UserId)
        {
            IndexViewModel model = new IndexViewModel();
            model.User=_repository.FindUser(UserId);
            model.Accounts = _repository.AllAccount().Where(x=>x.UserId==UserId).ToList();
            return View(model);
        }
        public ActionResult AddAccount(int UserId)
        {
            AddAcountViewModel model = new AddAcountViewModel();
            model.UserId = UserId;
            return View(model);
        }
        [HttpPost]
        public ActionResult AddAccount(AddAcountViewModel model)
        {
            if (ModelState.IsValid)
            {
                Account account = new Account
                {
                    Count = model.Account.Count,
                    User = _repository.FindUser(model.UserId),
                    CurrencyName = model.Account.CurrencyName,
                    Time = DateTime.Now,
                    DateLastChanges = null
                };
                _repository.AddAccount(account);
                return RedirectToAction("Index", new {model.UserId });
            }            
            return View(model);
        }
        public ActionResult ChangeAccount(int AccountId)
        {
            ChangeAccountViewModel model = new ChangeAccountViewModel();
            Account account=_repository.FindAccount(AccountId);
            model.UserId = (int)account.UserId;
            model.AccountId = AccountId;
            model.Count = account.Count;
            model.Name = account.CurrencyName;
            return View(model);
        }
        [HttpPost]
        public ActionResult ChangeAccount(ChangeAccountViewModel model)
        {
            Account account = new Account
            {
                Id=model.AccountId,
                Count=model.Count,
                CurrencyName=model.Name  
            };
            _repository.ChangeAccount(account);
            return RedirectToAction("Index", new {model.UserId});
        }
    }
}