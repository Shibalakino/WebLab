using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessagingApp.Models;
using Microsoft.AspNetCore.Identity;

namespace MessagingApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MessagingAppUser class
    public class MessagingAppUser : IdentityUser
    {
        public string Name { get; set; }
        //public List<Message> MessagesSent { get; set; }
        //public List<Message> MessagesRecieved { get; set; }
    }
}
