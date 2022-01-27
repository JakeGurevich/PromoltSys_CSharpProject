using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Models
{
    public class LoginModel
    {
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
