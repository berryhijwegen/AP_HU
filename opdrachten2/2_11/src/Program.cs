using System;

namespace StudentGegevens
{
    class Program
    {
        static void Main(string[] args)
        {
            Klas klas1 = new Klas("AAI-A1B");
            Student student1 = new Student("Bart", 18);
            Student student2 = new Student("Henk", 20);
            Student student3 = new Student("Kees", 20);
            
            klas1.voegStudentToe(student1);
            klas1.voegStudentToe(student2);
            klas1.voegStudentToe(student3);

            student1.voegCijferToe(6);
            student1.voegCijferToe(4);
            student2.voegCijferToe(9);
            student3.voegCijferToe(2);

            Console.WriteLine(student1.toString());
        }
    }
}
