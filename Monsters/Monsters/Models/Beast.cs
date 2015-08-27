using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.Models
{
    public enum TypeOfBeast { 
        Zombie,
        Vampire
    } 
    public enum RankTypes { 
        Junior,
        Capitan,
        SuperBeast,
        None
    }
    class Beast
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Speed { get; set; }
        public string CountryLocation { get; set; }
        public string CityLocation { get; set; }


        //wtf? we dont need this
        protected TypeOfBeast Beasts;  
        public virtual TypeOfBeast BeastType { get; set; } //we dont need "set" at all
        public int BittenPeople { get; set; }

        private RankTypes Rank; // privat field should be always be "rank" or "_rank"
        public RankTypes RankType
        {
            get
            {
                if (BittenPeople < 0)
                {
                    Rank = RankTypes.None;
                }
                else if (BittenPeople >= 0 && BittenPeople <= 15)
                {
                    Rank = RankTypes.Junior;
                }
                else if (BittenPeople >= 16 && BittenPeople <= 50)
                {
                    Rank = RankTypes.Capitan;
                }                
                else 
                {
                    Rank = RankTypes.SuperBeast;
                }

                return Rank;
            }
            set
            {
                Rank = value;
            }
        }
    }
}
