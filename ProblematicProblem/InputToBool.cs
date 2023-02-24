using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    public class InputToBool
    {
        public static bool InToBool()
        {
            var user = Console.ReadLine();
            switch (user.ToLower())
            {
                case "yes":
                    return true;

                case "no":
                    return false;
                default:
                    Console.WriteLine("invalid input, please try again: ");
                    return InToBool();
            }
        }
    }
}
