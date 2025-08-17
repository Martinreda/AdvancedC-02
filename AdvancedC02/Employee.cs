using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee:IComparable <Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salaray { get; set; }

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1;
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $" id : {Id}\n Name: {Name}\n Salary : {Salaray}";  
                }

    }
}
