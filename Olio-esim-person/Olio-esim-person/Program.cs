using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_esim_person
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.firstname = "Pekka";

            //tee yksi oppilasolio
            Student student = new Student();
            student.FirstName = "Teppo";
            student.LastName = "Terävä";
            student.Address = "Piippukatu 3";
            student.Age = 23;
            student.PhoneNumber = "040-84984839";
            student.StudentID = "h8888";
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Kirsi", "Kernel", "D554");
            teacher.Age = 35;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "020-1325232";
                Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

            student.PersonMethod(); //<-- Toimiiko? Ei.

            // olio ei ole aliluokan sisällä..
            //student.PersonMethod(); // <-- toimiiko?

        }
    }
}
