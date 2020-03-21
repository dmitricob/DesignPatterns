using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soliD_DependencyInversion.withSOLID
{
    class Class1
    {
        Book bookC = new Book(new ConsolePrinter()) { Text = "Console text"};
        Book bookH = new Book(new HtmlPrinter()) { Text = "Html text"};
        public Class1()
        {
            //print to console
            bookC.Print();

            bookC.Printer = new HtmlPrinter();
            //print to Html
            bookC.Print();
        }
    }
    interface IPrinter
    {
        void Print(string text);
    }

    class Book
    {
        public string Text { get; set; }
        public IPrinter Printer { get; set; }

        public Book(IPrinter printer)
        {
            this.Printer = printer;
        }

        public void Print()
        {
            Printer.Print(Text);
        }
    }

    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать на консоли");
        }
    }

    class HtmlPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать в html");
        }
    }
}
