using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Project_FactoryMethorPattern.Models
{
    public class Course : IEntity
    {

        public Course() { }
        public Course(int id, string name, int totalHour)
        {
            this.Id = id;
            this.Name = name;
            this.TotalHour = totalHour;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalHour { get; set; }
        public string GetDetails()
        {
            return $"Id: {Id} Name: {Name} Course Hour:{TotalHour}";
        }
    }
}
