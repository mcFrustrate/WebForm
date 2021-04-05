using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebForm.Models;

namespace WebForm.Pages.Forms
{
    public class EditModel : PageModel
    {
        public EditModel(PersonDBContext persondbcontext)
        {
            _persondbcontext = persondbcontext;
        }
        private readonly PersonDBContext _persondbcontext;

        [BindProperty]
        public PersonModel Person { get; set; }

        public void OnGet(int id)
        {
            Person = _persondbcontext.PersonModels.FirstOrDefault(person => person.ID == id);
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            { return Page(); }

            ///
            var p = _persondbcontext.PersonModels.FirstOrDefault(person => person.ID == Person.ID);
            if (p != null)
            {
                // assign the values of the textfield to var p
                p.LastName = Person.LastName;
                p.FirstName = Person.FirstName;
                p.Gender = Person.Gender;
                p.ContactNo = Person.ContactNo;
                p.Email = Person.Email;
                p.UserName = Person.UserName;
                p.Password = Person.Password;

                //Update the table by Update() function
                _persondbcontext.Update(p);
                // Save the changes
                _persondbcontext.SaveChanges();
            }
            return Redirect("/Forms/Register");
        }
    }
}

