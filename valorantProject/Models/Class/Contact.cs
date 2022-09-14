using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace valorantProject.Models.Class
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime date { get; set; }
        public bool isRead { get; set; }
    }
}