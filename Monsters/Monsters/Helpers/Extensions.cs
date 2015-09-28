using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsters.Helpers
{
    public static class Extensions
    {
        public static BindingList<T> ToBindingList<T>(this IEnumerable<T> value)
        {
            return new BindingList<T>(value.ToList());
        }
    }
}
