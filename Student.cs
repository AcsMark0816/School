using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Student
    {
        public string name { get; set; }
        public int ev { get; set; }

        public string gender { get; set; }
        public Student(string[] data)
        {
            if (data.Length == 3)
            {
                name = data[0];
                ev = int.Parse(data[1].Trim('.'));
                gender = data[2];
            }
        }
        public Student(string name, int ev, string gender)
        {
            this.name = name;
            this.ev = ev;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"{name},{ev},{gender}";
        }

    }
}


