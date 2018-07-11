using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonLib.Utils
{
    public static class ConsoleUtils
    {
        public static void PrintItems<T>(this IEnumerable<T> items)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            foreach(var item in items)
            {
                stringBuilder.Append(item.ToString() + " ");
            }

            Console.WriteLine(stringBuilder.ToString());
        }

        public static long CalcTickForFuncCall(Action action)
        {
            var ticks = DateTime.Now.Ticks;
            action();
            var total = DateTime.Now.Ticks - ticks;

            return total;
        }
    }
}
