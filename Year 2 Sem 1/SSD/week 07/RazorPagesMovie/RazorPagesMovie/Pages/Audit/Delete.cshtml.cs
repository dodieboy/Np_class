﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Audit
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public DeleteModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AuditRecord AuditRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AuditRecord = await _context.AuditRecords.FirstOrDefaultAsync(m => m.Audit_ID == id);

            if (AuditRecord == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AuditRecord = await _context.AuditRecords.FindAsync(id);

            if (AuditRecord != null)
            {
                _context.AuditRecords.Remove(AuditRecord);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
