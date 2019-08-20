using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void SendAPersonByValue(Person p)
        {
            // Change the age of "p"?
            p.personAge = 99;

            // Will the caller see this reassignment?
            p = new Person("Nikki", 99);
        }
    }
}
