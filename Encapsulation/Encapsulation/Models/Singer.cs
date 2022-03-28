using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    internal class Singer
    {
        private string name;
        private string surname;
        private int age;
        public Singer()
        {

        }
        

        public string Name
        {

            set
            {
                if (value.Length < 100) name = value;
                else Console.WriteLine("Input for Name is invalid");
            }
            get { return name; }
        }
        public string Surname 
        {
            
            set { if (value.Length < 100) surname = value;
                else Console.WriteLine("Input for Name is invalid"); }
            get { return surname; }
        }

        public int Age {
            
            set {
                if (value>0 && value <= 170)  age = value;
                else Console.WriteLine("Input for Age is invalid");
                }
            get { return age; }
        }


    }
}
