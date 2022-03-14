using Microsoft.AspNetCore.Mvc;
using PhoneBookLibrary;
using System.Collections.Generic;
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
            //get the contacts from the csv file
            FileManipulation.LoadContacts(contacts);

            //return the newly populated list 
            return contacts;
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact([FromBody] Contact contact)
        {
            //check if the object is null
            if (contact is null)
            {
                //if null return 400 Bad Request response
                return BadRequest();
            }

            //add the new contact to the list from the post request
            contacts.Add(contact);

            //save the new contact to the file
            FileManipulation.SaveContacts(contacts);

            //return 200 OK response
            return Ok(contact);
        }
    }
}
