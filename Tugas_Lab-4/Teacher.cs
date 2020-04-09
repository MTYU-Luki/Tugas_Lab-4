using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_4
{
    class Teacher : Person
    {
        public string Teacherid;
        public string Subject;

        public Teacher(string Nama, int Age, string Teacherid, string Subject) : base(Nama, Age)
        {
            this.Teacherid = Teacherid;
            this.Subject = Subject;
        }
    }
}
