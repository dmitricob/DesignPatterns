using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new StoneBuilder("Building stone");
            House sh = builder.Create();
            builder = new WoodBuilder("Building wood");
            House wh = builder.Create();
        }
    }

    abstract class Builder
    {
        public string Name { get; set; }

        protected Builder(string name)
        {
            Name = name;
        }

        abstract public House Create();
    }
    class StoneBuilder : Builder
    {
        public StoneBuilder(string n ) : base(n) 
        { }
        public override House Create()
        {
            return new StoneHouse();
        }
    }
    class WoodBuilder : Builder
    {
        public WoodBuilder(string n ) : base(n) 
        { }
        public override House Create()
        {
            return new WoodHouse();
        }
    }

    abstract class House { }
    class StoneHouse : House
    {
        public StoneHouse()
        {
            Console.WriteLine("stone house");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("wood house");
        }
    }


}
