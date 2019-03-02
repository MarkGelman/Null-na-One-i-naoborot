using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamena_simvolov_odin_na_odin
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string st = "";
            int len = str.Length;
            for (int i=0; i<len; i++)
            {
                if (str[i] == '0')
                    st = st + "1";
                else
                    if (str[i] == '1')
                             st = st + "0";
                else
                   st += str[i];
            }
            Console.WriteLine(st);
        }
    }
}
