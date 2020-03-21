using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soLid_Listkov
{
    class Program
    {
        static void Main(string[] args)
        {
            // we cannot replace User with UserA in case when thay do same for program 
            // we think that user and userA cannot include age < 0
            UserA usera = new UserA(-1); 
            User user = new User(-1);
        }
    }

    class User
    {
        protected int age;

        public User(int age)
        {
            Age = age;
        }

        public virtual int Age 
        { 
            get 
            { 
                return age; 
            } 
            set 
            {
                if (value < 0)
                    throw new Exception("Wrong age < 0");
                this.age = value;
            } 
        }
    }

    class UserA : User
    {
        public UserA(int age) : base(age)
        {
        }

        public override int Age 
        { 
            get => base.Age;
            set 
            {
                age = value;
            }
        }
    }

}
