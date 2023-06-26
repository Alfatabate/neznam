using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ActionDVD : DVD
    {
        public string ActionGenre { get; set; }

        public override void InputData()
        {
            Console.WriteLine("Enter DVD Number:");
            DVDNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Title:");
            Title = Console.ReadLine();

            Console.WriteLine("Enter Duration (minutes):");
            Duration = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Action Genre:");
            ActionGenre = Console.ReadLine();
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Action DVD Information:");
            base.PrintInfo();
            Console.WriteLine("Genre: " + ActionGenre);
        }

        public override double GetDuration()
        {
            return Duration;
        }
    }
}
