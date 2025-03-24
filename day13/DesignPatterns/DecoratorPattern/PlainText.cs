using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class PlainText
    {

        public string GetText()
        {
            return "Hello World !";
        }
    }

    public class BoldText
    {
        private PlainText _text;


        public BoldText(PlainText text)
        {
            _text = text;
        }

        public string GetText()
        {
            //logic

            return "<b>" + _text.GetText() + "</b>";
        }
    }

    public class ItalicText
    {
        private PlainText _text;


        public ItalicText(PlainText text)
        {
            _text = text;
        }

        public string GetText()
        {
            return "<i>" + _text.GetText() + "</i>";
        }
    }
}