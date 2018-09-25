using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() {
                Name = "Juan",
                LastName = "Perez"
            };

            Student s = new Student()
            {
                Name = "Juan",
                LastName = "Perez",
                Average = 8.5
            };

            Professor pr = new Professor()
            {
                Name = "Juan",
                LastName = "Perez",
                Courses = new string[] {"DAS C3 "}
            };

            //Console.WriteLine(PrintReport(p));
            //Console.WriteLine(PrintReport(s));

            PrintReport(p);
            PrintReport(s);
            PrintReport(pr);

            Console.ReadKey();

        }

        public static void PrintReport(Person p)
        {
            Console.WriteLine(p.GetSummary());
        }


        //public static string PrintReport(Person p)
        //{
        //    return p.Name + " " + p.LastName;
        //}

        //public static string PrintReport(Student p)
        //{
        //    return p.Name + " " + p.LastName + " " + p.Average;
        //}
    }
}
