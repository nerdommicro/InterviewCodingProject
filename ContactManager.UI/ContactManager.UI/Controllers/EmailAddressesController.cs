using ContactManager.BL.Data;
using ContactManager.BL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class EmailAddressesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmailAddressesController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<EmailAddresses> objEmailAddressesList = _db.EmailAddresses;
            return View(objEmailAddressesList);
        }
        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmailAddresses obj)
        {
            if (ModelState.IsValid)
            {
                _db.EmailAddresses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public ActionResult New()
        {
            var email = new EmailAddresses();
          
            return View(email);
        }
    }
}
