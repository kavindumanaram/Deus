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
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ActionResult Index()
        {
            IEnumerable<User> books = _userRepository.GetAllUsers();
            int userCount = _userRepository.Count();
            return View(books);
        }
    }
}