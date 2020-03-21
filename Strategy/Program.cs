using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new PetrollMove());
            car.Move();
            car.Movable = new EllectroMove();
            car.Move();
        }

    }
    interface IMovable
    {
        void Move();
    }

    class PetrollMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("petroll move");
        }
    }
    class EllectroMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Elelectro move");
        }
    }

    class Car
    {
        public IMovable Movable { private get; set; }

        public Car(IMovable movable)
        {
            Movable = movable;
        }

        public void Move()
        {
            Movable.Move();
        }
    }
}
