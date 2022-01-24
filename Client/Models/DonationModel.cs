
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class DonationModel
    {

       
        public string? Id { get; set; }
        public string ProductName { get; set; } = null!;
        public int Qty { get; set; }
        public decimal? Price { get; set; }
        
     
        public string DonatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
