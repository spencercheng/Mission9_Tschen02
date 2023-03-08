using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_Tschen02.Models
{
    public class EFDonationRepository : IDonationRepository
    {
        private BookstoreContext context;
        public EFDonationRepository(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Purchase> Donations => context.Donations.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SaveDonation(Purchase donation)
        {
            context.AttachRange(donation.Lines.Select(x => x.Book));
            if(donation.PurchaseId== 0)
            {
                context.Donations.Add(donation);
            }
            context.SaveChanges();
        }
    }
}
