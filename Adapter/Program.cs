using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Auto car = new Auto();
            driver.Travel(car);
            Camel camel = new Camel();
            CammelToTransportAdapter adapter = new CammelToTransportAdapter(camel);
            driver.Travel(adapter);
        }
    }

    interface ITransport
    {
        void Drive();
    }

    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Drive on car");
        }
    }

    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }

    interface IAnimel
    {
        void Move();
    }

    class Camel : IAnimel
    {
        public void Move()
        {
            Console.WriteLine("Move on camel");
        }
    }

    class CammelToTransportAdapter : ITransport
    {
        Camel camel;
        public CammelToTransportAdapter(Camel camel)
        {
            this.camel = camel;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
}
