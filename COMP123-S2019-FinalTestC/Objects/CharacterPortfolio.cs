﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME: Seyed Behzad Afrasiabi
 * STUDENT ID: 300-605-726
 * DESCRIPTION: This is the main container class for the application
 * GitHub: https://github.com/BehzadScorpion/COMP123-S2019-FinalTestC-master
 * Last Modified: 8/14/2019, 11:54am
 */

namespace COMP123_S2019_FinalTestC.Objects
{
    public class CharacterPortfolio
    {
        // Identity
        public Identity Identity { get; set; }

        // characteristics
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }

        // Skill List
        public List<string> Skills;

        // constructor
        public CharacterPortfolio()
        {
            this.Skills = new List<string>();
            this.Identity = new Identity();
        }
    }
}
