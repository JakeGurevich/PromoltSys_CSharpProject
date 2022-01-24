using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Models
{
    public class ItemModel
    {
        public string Title { get; set; } = null!;
        public decimal Price { get; set; }
        public int Qty { get; set; }    
    }
}
