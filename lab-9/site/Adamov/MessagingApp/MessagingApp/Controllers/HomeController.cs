using MessagingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static MessagingApp.Helper;
using Microsoft.EntityFrameworkCore;

namespace MessagingApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly MessageContext _context;

        public HomeController(MessageContext context)
        {
            _context = context;
        }

        // GET: Message
        public async Task<IActionResult> Index()
        {
            return View(await _context.Messages.ToListAsync());
        }

        // GET: Message/AddOrEdit
        // GET: Message/AddOrEdit/5
        //[NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id)
        {
            if (id == 0)
                return View(new Message());
            else
            {
                var message = await _context.Messages.FindAsync(id);
                if (message == null)
                {
                    return NotFound();
                }
                return View(message);
            }
        }

        // POST: Message/AddOrEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("MessageId,SenderName,RecieverName,Text")] Message message)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    _context.Add(message);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(message);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!MessageExists(message.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }

                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_AllMessagesPartial", _context.Messages.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", message) });
        }

        // POST: Message/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var message = await _context.Messages.FindAsync(id);
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_AllMessagesPartial", _context.Messages.ToList()) });
        }

        private bool MessageExists(int id)
        {
            return _context.Messages.Any(e => e.Id == id);
        }
    }
}
