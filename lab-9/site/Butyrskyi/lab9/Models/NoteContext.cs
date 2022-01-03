
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace lab9.Models
{
    public class NoteContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public NoteContext(DbContextOptions<NoteContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
