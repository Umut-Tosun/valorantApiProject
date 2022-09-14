using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace valorantProject.Models
{
    public class DataModel
    {
        public string assetPath { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public string displayIcon { get; set; }

        public string killStreamIcon { get; set; }



        public bool isFullPortraitRightFacing { get; set; }
        public bool isPlayableCharacter { get; set; }
        public string fullPortrait { get; set; }
        public Role role { get; set; }
        public List<Ability> abilities { get; set; }
    }
}