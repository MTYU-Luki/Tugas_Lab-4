using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_4
{
    public class Person
    {
        public string Nama;
        public int Age;

        public Person(string Nama, int Age)
        {
            this.Nama = Nama;
            this.Age = Age;
        }
        
        public void GetNameAndAge()
        {
            Console.WriteLine("The Person has Name : {0} and Age : {1}", Nama, Age);
        }

    }
}
