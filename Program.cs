namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School s = FileManager.Readfile("students.csv");
            foreach(var x in s.Students)
            {
                Console.WriteLine(x);
            }
        }
    }
}
