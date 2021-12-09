using ContactManager.BL.Data;
using ContactManager.BL.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContactController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            IEnumerable<Contact> objContactsList = _db.Contacts;
            return View(objContactsList);
        }
        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contact obj)
        {            
            if (ModelState.IsValid)
            {
                _db.Contacts.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public ActionResult New()
        {
            var contact = new Contact();            
            return View(contact);
        }
    }
}
