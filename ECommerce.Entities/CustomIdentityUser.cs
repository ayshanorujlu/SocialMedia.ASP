using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Entities
{
    public class CustomIdentityUser : IdentityUser<string>
    {
        public string? ImageUrl { get; set; }
        public bool IsFriend { get; set; }
        public bool IsOnline { get; set; }
        public bool HasRequestPending { get; set; }
        public DateTime DisconnectTime { get; set; } = DateTime.Now;
        public string ConnectTime { get; set; } = "";
    }
}