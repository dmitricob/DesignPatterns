using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Move();
            Hero warrior = new Hero(new WarriorFactory());
            elf.Hit();
            elf.Move();
        }

    }

    abstract class Weapon
    {
        public abstract void Hit();
    }
    abstract class Movement
    {
        public abstract void Move();
    }

    class Arballet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("arballet shoot");
        }
    }

    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("sword swing");
        }
    }

    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Running");
        }
    }

    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }

    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arballet();
        }
    }

    class WarriorFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }

    class Hero
    {
        private Weapon weapon;
        private Movement movement;

        public Hero(HeroFactory heroFactory)
        {
            weapon = heroFactory.CreateWeapon();
            movement = heroFactory.CreateMovement();
        }

        public void Move()
        {
            movement.Move();
        }

        public void Hit()
        {
            weapon.Hit();
        }
    }
}
