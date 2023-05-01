using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03Project_FactoryMethorPattern.Models
{
    public class Trainee : IEntity
    {
        public Trainee() { }
        public Trainee(int id, string name, int courseId, int round)
        {
            this.Id = id;
            this.Name = name;
            this.CourseId = courseId;
            this.Round = round;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public int Round { get; set; }
        public string GetDetails()
        {
            return $"Id: {Id} Name: {Name} Course Id: {CourseId} Round: {Round}";
        }
    }
}
