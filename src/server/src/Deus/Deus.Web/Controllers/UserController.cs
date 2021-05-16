using Deus.Domain.Users;
using Deus.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deus.Persistence;

namespace Deus.Web.Controllers
{
    public class UserController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<User> bookRepository;

        public UserController()
        {
            bookRepository = unitOfWork.Repository<User>();
        }

        public ActionResult Index()
        {
            IEnumerable<User> books = bookRepository.Table.ToList();
            return View(books);
        }
    }
}