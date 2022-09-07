using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace valorantProject.Models.Class
{
    public class Maps
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string lineUpUrl { get; set; }
        public string Description { get; set; }
       
    }
}