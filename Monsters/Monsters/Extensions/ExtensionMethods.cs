using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monsters.Models;
using Monsters;
using System.ComponentModel;

namespace Monsters.Extensions
{
    public static class ExtensionMethods
    {        public static IEnumerable<Beast> ToBindingList(this List<Beast> str)
        {
            List<Beast> convertToBindingList = new BindingList<Beast>(str).ToList();
            return convertToBindingList;
        }
    }
}
