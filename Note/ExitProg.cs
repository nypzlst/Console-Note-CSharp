using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    public class ExitProg
    {
        public void Exit()
        {
            Console.WriteLine("Do you want to continue? y/n");
            string answer = Console.ReadLine();
            if (answer == "n")
            {
                Console.WriteLine("Exit");
            }
            else
            {
                Runtime call = new Runtime();
                call.StartConNote();
            }
        }


    }
}
