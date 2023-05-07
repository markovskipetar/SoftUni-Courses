namespace Phonebook.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using Phonebook.Data;
    using Phonebook.Data.Models;

    public class ContactController : Controller
    {
        public IActionResult Create(string number, string photo)
        {
            Contact contact = new Contact(int.Parse(number), photo);

            DataAccess.Contacts.Add(contact);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(string numberRemove)
        {
            int number = int.Parse(numberRemove);

            DataAccess.Contacts.RemoveAll(contact => contact.Number == number);

            return RedirectToAction("Index", "Home");
        }
    }
}
