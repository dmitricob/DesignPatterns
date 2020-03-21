using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_SingleResponsibility
{
    // move printer to another class 
    interface IPrinter
    {
        void Print(string text);
    }

    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    class ReportSOLID
    {
        public string Text { get; set; }

        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("Переход к странице {0}", pageNumber);
        }
        public void Print(IPrinter printer)
        {
            printer.Print(this.Text);
        }
    }

}
