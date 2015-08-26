using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.Models
{
    class Zombie : Beast
    {
        public string Zomb { get; set; }
        public int EatenPeople { get; set; }
    }
}
