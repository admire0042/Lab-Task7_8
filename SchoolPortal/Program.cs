using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("Enter your registration number: ");
        string regno = Console.ReadLine();
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your department, SCI or COM: ");
        string depart = Console.ReadLine();
        string dept = depart.ToUpper();

        ScienceStudent sciencestudent = new ScienceStudent(regno, name, 75, 60, 80);

        CommerceStudent commercestudent = new CommerceStudent(regno, name, 71, 67, 55);

        if(dept == "SCI")
        {
            Console.WriteLine(sciencestudent.ToString());
        }
        else if(dept == "COM")
        {
            Console.WriteLine(commercestudent.ToString());
        }

        }
    }
}
