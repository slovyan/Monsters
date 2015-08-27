using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.Models
{
    public enum RankTypes { 
        Junior,
        Capitan,
        SuperBeast
    }
    class Beast
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public string CountryLocation { get; set; }
        public string CityLocation { get; set; }
        public string BeastType { get; set; }
        public int BittenPeople { get; set; }

        private RankTypes Rank;
        public RankTypes RankType
        {
            get
            {
                if (BittenPeople >= 0 && BittenPeople <= 15)
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
