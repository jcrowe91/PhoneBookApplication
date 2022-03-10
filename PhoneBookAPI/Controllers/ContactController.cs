using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBookLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        List<Contact> contacts = new List<Contact>();
        [HttpGet]
        public List<Contact> GetAll()
        {
            FileManipulation.LoadContactsCSV(contacts, $"{Directory.GetCurrentDirectory()}/Contacts.txt");
            return contacts;
        }
    }
}
