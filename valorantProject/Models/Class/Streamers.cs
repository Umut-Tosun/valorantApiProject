using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace valorantProject.Models.Class
{
    public class Streamers
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }   
        public string Description { get; set; }
        public string Image { get; set; }
        public string YoutubeUrl { get; set; }
        public string TwitchUrl { get; set; }
        public bool status { get; set; }
    }
}