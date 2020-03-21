using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soliD_DependencyInversion.noSOLID
{
    class Class1
    {
        Book book = new Book {Text = "bookText" };

    }
    class Book
    {
        public string Text { get; set; }
        public ConsolePrinter Printer { get; set; }

        public void Print()
        {
            Printer.Print(Text);
        }
    }

    class ConsolePrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
