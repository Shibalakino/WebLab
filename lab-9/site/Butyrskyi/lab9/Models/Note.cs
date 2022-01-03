using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lab9.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string NoteNumber { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("User Name")]
        [Required(ErrorMessage = "This Field is required.")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Topic Name")]
        [Required(ErrorMessage = "This Field is required.")]
        public string TopicName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [DisplayName("Note Text")]
        [Required(ErrorMessage = "This Field is required.")]
        public string NoteText { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    }
}