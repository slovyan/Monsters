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
    public class Beast
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Speed { get; set; }
        public string CountryLocation { get; set; }
        public string CityLocation { get; set; }


        public virtual TypeOfBeast BeastType {
            get
            { 
                return BeastType;
            }
        } //we dont need "set" at all

        public int BittenPeople { get; set; }

        private RankTypes rank; // privat field should be always be "rank" or "_rank"
        public RankTypes RankType
        {
            get
            {
                if (BittenPeople < 0)
                {
                    rank = RankTypes.None;
                }
                else if (BittenPeople >= 0 && BittenPeople <= 15)
                {
                    rank = RankTypes.Junior;
                }
                else if (BittenPeople >= 16 && BittenPeople <= 50)
                {
                    rank = RankTypes.Capitan;
                }                
                else 
                {
                    rank = RankTypes.SuperBeast;
                }

                return rank;
            }
            set
            {
                rank = value;
            }
        }
    }
}
