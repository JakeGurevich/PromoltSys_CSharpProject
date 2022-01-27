using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class OrderModel
    {
        public string? Id { get; set; }
        public List<ItemModel> Cart { get; set; } = null!;

        public decimal TotalPrice { get; set; }

       
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
