using MessagingApp.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingApp.Models
{
    public class Message
    {

        public int Id { get; set; }
        public string SenderName { get; set; }

        [Required(ErrorMessage = "You need to specify the reciever")]//?
        public string RecieverName { get; set; }

        [Required(ErrorMessage = "You need to write something")]//?
        public string Text { get; set; }

        //public MessagingAppUser Sender { get; set; }
        //public MessagingAppUser Reciever { get; set; }
    }
}
