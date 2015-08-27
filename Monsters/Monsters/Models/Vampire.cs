using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.Models
{
    class Vampire : Beast
    {
        public override TypeOfBeast BeastType
        {
            get
            {
                return Beasts;
            }
            set
            {
                Beasts = TypeOfBeast.Vampire;
            }
        }  
        
    }
}
