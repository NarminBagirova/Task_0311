using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0311
{
    public class BackEndDeveloper : Developer
    {
        public BackEndDeveloper():base()
        {

        }

        public BackEndDeveloper(string name): base(name)
        {

        }

        public BackEndDeveloper(string name, string surname): base(name, surname)
        {
     
        }
        public BackEndDeveloper(string name, string surname, double experience): base(name, surname, experience)
        {

        }

        public BackEndDeveloper(string name, string surname, double experience, double sqlExperience):this(name, surname, experience)
        {
            SqlExperience= sqlExperience;
        }

        public double SqlExperience;
    }
}
