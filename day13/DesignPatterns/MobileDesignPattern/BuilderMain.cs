using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDesignPattern
{
    public class BuilderMain
    {
        public static void Main(string[] args)
        {
            Mobile Android = new Builder()
                               .setStorage("32GB")
                                .setos("Android")
                                .Build();

            Android.showSpecification();
        }
    }

}
