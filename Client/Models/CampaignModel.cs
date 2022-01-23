
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class CampaignModel
    {

        public string? Id { get; set; }
        public string Title { get; set; } = null!;
        public string Hashtag { get; set; } = null!;
        public string Url { get; set; } = null!;
       
        public string CreatedBy { get; set; } = null!;
        public DateTimeOffset CreatedAt { get; set; }
    }
}
