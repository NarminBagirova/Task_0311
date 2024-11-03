using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0311
{
    internal class FrontEndDeveloper : Developer
    {
        public FrontEndDeveloper(string name, string surname, double experience) : base(name, surname, experience)
        {

        }

        public void ShowFullData()
        {
            Console.WriteLine($"{Name}, {Surname}, {Experience}");
        }
    }
}
