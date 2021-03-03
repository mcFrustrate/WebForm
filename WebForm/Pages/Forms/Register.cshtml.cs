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
        [BindProperty]
        public PersonModel Person { get; set;}
        
        //GET Handler
        public void OnGet()
        {
        }

        //POST Handler
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid) 
            { return Page(); }
            return Redirect("/Index");
            /*string Lname = Request.Form["LName"];
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
