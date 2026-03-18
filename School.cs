using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class School

    {
        public List<Student> Students { get; set; }
        public School(List<Student> school)
        {
            Students = school;
        }
        public School()
        {
            Students = new List<Student>();
        }

        public bool FireStudent(string name)
        {
           foreach(Student x in Students)
            {
               
                if (Students.Contains(x))
                {
                    Students.Remove(x);
                    
                }
               
                
                
            }
            return true;
        }

        public void Hire(string name, int ev,string gender)
        {
            Students.Add(new Student(name, ev, gender));
        }
        public int CountStudent()
        {
            return Students.Count();
        }
        public void Plantree(int plusszstudent, string name,int ev,string gender)
        {
            Students.Insert(plusszstudent, new Student (name,ev,gender));
        }

    }
}
