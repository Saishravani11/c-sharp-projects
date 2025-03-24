using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class DecoratorMain
    {

        static void Main()
        {
            //Basic text

            PlainText txt = new PlainText();
            Console.WriteLine(txt.GetText);

            BoldText t = new BoldText(txt);
            Console.WriteLine(t.GetText());

            ItalicText it = new ItalicText(txt);
            Console.WriteLine(it.GetText());

        }
    }
}