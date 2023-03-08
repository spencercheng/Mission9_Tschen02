using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_Tschen02.Models
{
    public interface IDonationRepository
    {
        public IQueryable<Purchase>Donations { get; }
        void SaveDonation(Purchase donation);
    }
}
