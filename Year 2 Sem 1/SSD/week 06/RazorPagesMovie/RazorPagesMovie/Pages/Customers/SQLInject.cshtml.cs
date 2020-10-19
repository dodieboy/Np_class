using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Customers
{
    public class SQLInjectModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;
        public SQLInjectModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }
        public IList<Customer> Customer { get; set; }
        public string SQLmessage { get; set; }

        //[RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Entered Text contain Invalid characters")]
        public string SearchString { get; set; }
        public async Task OnGetAsync(String SearchString)
        {

            //SQLmessage = "Select * From Customers Where Name Like '%" + SearchString + "%'";
            //Customer = await _context.Customers.FromSql(SQLmessage).ToListAsync();
            //TempData["message"] = "Entered SQL :" + SQLmessage;

            if (String.IsNullOrEmpty(SearchString))
                SearchString = "%";
            string query = "SELECT * FROM Customers WHERE Name like {0}";
            Customer = await _context.Customers.FromSql(query, SearchString).ToListAsync();

        }

        public async Task<IActionResult> OnPostAsync(String SearchString)
        {
            return RedirectToPage("./Index");
        }

    }
}
