using MessagingApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingApp.Models
{
    public class MessageContext : IdentityDbContext<MessagingAppUser>
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessagingAppUser> MessagingAppUsers { get; set; }
        public MessageContext(DbContextOptions<MessageContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
    }
}
