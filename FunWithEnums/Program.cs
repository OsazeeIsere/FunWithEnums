using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    enum EmpType
    {
        Manager, //=0
        Grunt,  //=1
        Contractor, //=2
        VicePresident //=3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Fun with Enums******");
            //make an EmpType variable and also get the type
            EmpType emp = EmpType.Grunt;
            AskForBonus(emp);
            //MORE fun
            EmpType emp1 = EmpType.Manager;
            AskForBonus(emp1);

            // print storage for the enum
            Console.WriteLine($"EmpType uses {Enum.GetUnderlyingType(emp.GetType())} for storage");
            // prints out employee is a manager
            Console.WriteLine($"Employee is a {emp1.ToString()}");

            //prints out manager=0
            Console.WriteLine($"{emp1.ToString()} =  {(int)emp}");

            //checking the enums in system namespace
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.DarkGray;

            EvaluateEnum(day);
            EvaluateEnum(cc);

        }

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about{0}", e.GetType().Name);
            Console.WriteLine("underlying storage type:{0}", Enum.GetUnderlyingType(e.GetType()));

            //get all name-value pairs for all incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine($"this Enum has {enumData.Length} members");

            //NOW show the string name and associated value, using the D format
            //flag
            for (int i=0;i< enumData.Length; i++)
            {
                Console.WriteLine($"Name:{enumData.GetValue(i)} Value:{enumData.GetValue(i):D}");
            }
            Console.WriteLine();
        }

        private static void AskForBonus(EmpType e)
        {
                // Enums as parameter
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already got enough cash..");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD SIR..");
                    break;

            }

        }

       
    }
}
