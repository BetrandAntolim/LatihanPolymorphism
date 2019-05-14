using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Name = "Epson";

            Console.WriteLine("{0} display dimesion : 10*11", Name);
        }
    }
}
