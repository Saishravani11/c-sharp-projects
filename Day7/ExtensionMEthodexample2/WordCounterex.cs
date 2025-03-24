using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMEthodexample2
{


    static class StringCount
    {

        public static int GetWordCounted(this string inputString)
        {

            if (!string.IsNullOrEmpty(inputString))
            {

                string[] strArray = inputString.Split(' ');
                return strArray.Count();
            }
            else
            {

                return 0;
            }

        }
    }

}