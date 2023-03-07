using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission9_Tschen02.Infrastructure;
using Mission9_Tschen02.Models;

namespace Mission9_Tschen02.Pages
{
    public class DonateModel : PageModel
    {
        private IBookProjectRepository repo { get; set; }
        public Basket basket { get; set; }
        public DonateModel (IBookProjectRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
            basket.AddItem(b, 1);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookId).Book);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
