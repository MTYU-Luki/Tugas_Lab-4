using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_4
{
    class Students : Person
    {
        public string Studentid;
        public string Email;

        public Students(string Nama, int Age, string Studentid, string Email) : base(Nama, Age)
        {
            this.Studentid = Studentid;
            this.Email = Email;
        }
    }
}
