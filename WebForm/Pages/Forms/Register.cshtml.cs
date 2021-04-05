using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebForm.Models;

namespace WebForm.Pages.Forms
{
    public class RegisterModel : PageModel
    {
        public RegisterModel(PersonDBContext personcontext)
        {
            _persondbcontext = personcontext;
        }

        // create property for DBContext instance
        private readonly PersonDBContext _persondbcontext;

        [BindProperty]
        public PersonModel Person { get; set; }

        public List<PersonModel> Persons = new List<PersonModel>();
        
        //GET Handler
        public void OnGet()
        {
            Persons = _persondbcontext.PersonModels.ToList();
        }

        //custom Delete
        public void OnGetDelete(int id)
        {
            var p = _persondbcontext.PersonModels.FirstOrDefault(person => person.ID == id);
            if (p != null)
            {
                _persondbcontext.PersonModels.Remove(p);
                _persondbcontext.SaveChanges();
            }
            OnGet();
        }


        //POST Handler
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Persons = _persondbcontext.PersonModels.ToList();
                return Page(); 
            }
            
            _persondbcontext.PersonModels.Add(Person);
            _persondbcontext.SaveChanges();
            return Redirect("/Forms/Register");

            /*if (!ModelState.IsValid) 
            { return Page(); }
            return Redirect("/Index");
            /string Lname = Request.Form["LName"];
            string Fname = Request.Form["FName"];
            string Gender = Request.Form["gender"];
            string ContactNo = Request.Form["contactNo"];
            string Email = Request.Form["email"];
            string Uname = Request.Form["uName"];
            string Pwd = Request.Form["pwd"];
            HttpResponseWritingExtensions.WriteAsync(this.Response,"Fullname: "+Lname+","+Fname+"\nGender: "+Gender+"\n");
*/
        }
    }
}
