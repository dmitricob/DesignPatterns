using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer freelanceProgramer = new FreelanceProgrammer(new CSarpLanguage());
            freelanceProgramer.Language = new CPPLanguage();
        }
    }

    interface ILanguage
    {
        void Build();
        void Execute();
    }

    class CPPLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("cpp build");
        }
        public void Execute()
        {
            Console.WriteLine("cpp execute;");
        }
    }
    class CSarpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("charp build");
        }
        public void Execute()
        {
            Console.WriteLine("charp execute;");
        }
    }

    abstract class Programmer
    {
        protected ILanguage language;
        public ILanguage Language
        {
            set { Language = value; }
        }
        public Programmer(ILanguage language)
        {
            Language = language;
        }
        public void DoWork()
        {
            language.Build();
            language.Execute();
        }
        public abstract void Earmoney();
    }

    class FreelanceProgrammer : Programmer 
    {
        public FreelanceProgrammer(ILanguage language) : base(language)
        {
        }

        public override void Earmoney()
        {
            Console.WriteLine("Get sallary for project");
        }
    }
    class CorparateProgrammer : Programmer 
    {
        public CorparateProgrammer(ILanguage language) : base(language)
        {
        }

        public override void Earmoney()
        {
            Console.WriteLine("Get sallary in month");
        }
    }
}
