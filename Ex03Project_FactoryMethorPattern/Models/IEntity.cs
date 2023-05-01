using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Project_FactoryMethorPattern.Models
{
    public interface IEntity
    {
        int Id { get; set; }
        string GetDetails();
    }
}
