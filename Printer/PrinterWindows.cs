using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class PrinterWindows
    {
        public string Name { get; set; }
        
        public virtual void Show()
        {
            Console.WriteLine("{0} display dimesion : N/A", Name);
        }
        public virtual void Print()
        {
            Console.WriteLine("{0} printer printing....", Name);
        }
    }
}
