using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("mike", 28);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 35, "190302", "Math");
            teacher.GetNameAndAge();

            Students students = new Students("Sara", 19, "10506", "sara123@amikom.ac.id");
            students.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
