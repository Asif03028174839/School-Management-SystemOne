using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_SystemOne
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Teacher mathteacher = new Teacher();
            mathteacher.Name = "Hassan";
            mathteacher.Birthday = 2-02-1990;
            mathteacher.Speciality = "Math";


            Teacher urduteacher = new Teacher();
            urduteacher.Name = "Abdullah";
            urduteacher.Birthday = 2 - 02 - 1991;
            urduteacher.Speciality = "Urdu";


            Teacher engteacher = new Teacher();
            engteacher.Name = "Imran";
            engteacher.Birthday = 2 - 02 - 1994;
            engteacher.Speciality = "English";


            Console.WriteLine(urduteacher.Name);
            Console.ReadLine();


        }
    }
}
