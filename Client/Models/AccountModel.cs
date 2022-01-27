
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class AccountModel
    {

        
        public string? Id { get; set; }
        public decimal Cash { get; set; }
        public decimal TotalCashSpend { get; set; }
        public string Owner { get; set; } = null!;
        public string SocialUserName { get; set; } = null!;
    }
}
