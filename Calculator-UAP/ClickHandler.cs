using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_UAP
{
    class ClickHandler
    {
        public static bool isDot(string num)
        {
            string[] splitStr = num.Split('.');
            if (splitStr.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
