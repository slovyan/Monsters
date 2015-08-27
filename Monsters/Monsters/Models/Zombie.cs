﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.Models
{
    class Zombie : Beast
    {
        public override TypeOfBeast BeastType
        {
            get
            {
                return Beasts;
            }
            set 
            {
                Beasts = TypeOfBeast.Zombie; 
            }
        }        
    }
}
