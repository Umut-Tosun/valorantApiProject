using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace valorantProject.Models
{
    public class Tier
    {
        public int tier { get; set; }
        public string tierName { get; set; }
        public string division { get; set; }
        public string divisionName { get; set; }
        public string color { get; set; }
        public string backgroundColor { get; set; }
        public string smallIcon { get; set; }
        public string largeIcon { get; set; }
        public string rankTriangleDownIcon { get; set; }
        public string rankTriangleUpIcon { get; set; }
    }
}