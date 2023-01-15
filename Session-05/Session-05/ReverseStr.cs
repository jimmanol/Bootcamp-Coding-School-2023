using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ReverseStr
    {
        public string PrintRev()
        {
            string name = "Dimitris Manolas";
            string revName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                revName = revName + name[i];
            }
            return revName;
        }
    }
}
