using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class FileManager
    {
        public static School Readfile(string filename)
        {
            School school = new();
            try
            {
                List<Student> students = new List<Student>();
                foreach(string line in File.ReadAllLines(filename, Encoding.UTF8).Skip(1)){
                    string[] temp = line.Split(";");
                    if(temp.Length == 3)
                    {
                        students.Add(new Student(temp));
                    }
                    school = new(students);
                }
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
            return school;
        }
    }
}
