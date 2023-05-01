using Ex03Project_FactoryMethorPattern.Factories;
using Ex03Project_FactoryMethorPattern.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Project_FactoryMethorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEntityFactory ef = new EntityFactory();
            TestFactory tf = new TestFactory(ef);
            tf.RunTest();
            Console.ReadLine();
        }
    }
}
