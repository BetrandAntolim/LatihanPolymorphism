using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Name = "Canon";

            Console.WriteLine("{0} display dimesion : 9.5*12", Name);
        } 
    }
}
