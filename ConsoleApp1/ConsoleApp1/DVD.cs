using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class DVD : IDVD
    {
        public int DVDNumber { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }

        public abstract void InputData();

        public virtual void PrintInfo()
        {
            Console.WriteLine("DVD Number: " + DVDNumber);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Duration: " + Duration + " minutes");
        }

        public abstract double GetDuration();
    }
}
