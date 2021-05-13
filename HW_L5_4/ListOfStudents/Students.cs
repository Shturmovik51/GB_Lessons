using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_4.ListOfStudents
{
    public struct Students
    {
        public string name;
        public string surname;
        public int grade1;
        public int grade2;
        public int grade3;

        public Students(string name, string surname, int grade1, int grade2, int grade3)
        {
            this.name = name;
            this.surname = surname;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
        }
    }
}
