using Ex03Project_FactoryMethorPattern.Factories;
using Ex03Project_FactoryMethorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Project_FactoryMethorPattern.Tests
{
    public class TestFactory
    {
        private readonly IEntityFactory factory;
        public TestFactory(IEntityFactory factory)
        {
            this.factory = factory;
        }
        public void RunTest()
        {
            List<Course> courses = new List<Course>()
            {
                 factory.Create<Course>(1, "ESAD", 980),
                 factory.Create<Course>(2, "DDD", 900),
                 factory.Create<Course>(3, "GAVE", 920)
            };
            Console.WriteLine("List of course");
            courses
            .ForEach(c => Console.WriteLine(c.GetDetails()));
            Console.WriteLine();
            List<Trainee> trainees = new List<Trainee>()
            {
                 factory.Create<Trainee>(1, "Kamrul Islam",1, 54),
                 factory.Create<Trainee>(2, "Amran Hossain", 2, 54),
                 factory.Create<Trainee>(3, "Mohiuddin", 1, 54)
            };
            Console.WriteLine("List of trainee");
            trainees
            .ForEach(t => Console.WriteLine(t.GetDetails()));
        }

    }
}
