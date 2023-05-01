using Ex03Project_FactoryMethorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Project_FactoryMethorPattern.Factories
{
    public class EntityFactory : IEntityFactory
    {
        public T Create<T>(params object[] args) where T : class, IEntity, new()
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }

    }
}
