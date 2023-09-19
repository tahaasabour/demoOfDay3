using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Name}";
        }

        public static implicit operator double(Trainee trinee)
        {
            return trinee.Id;
        }
    }
}
