using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class DVDCollection
    {
        private List<DVD> dvds;

        public DVDCollection()
        {
            dvds = new List<DVD>();
        }

        public void AddDVD()
        {
            Console.WriteLine("Enter the number of DVDs to add:");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter DVD Type (1 - Action DVD):");
                int dvdType = Convert.ToInt32(Console.ReadLine());

                DVD dvd;

                if (dvdType == 1)
                {
                    dvd = new ActionDVD();
                }
                else
                {
                    Console.WriteLine("Invalid DVD Type!");
                    continue;
                }

                dvd.InputData();
                dvds.Add(dvd);
            }
        }

        public void PrintAllDVDs()
        {
            Console.WriteLine("DVD Collection Information:");

            foreach (var dvd in dvds)
            {
                dvd.PrintInfo();
                Console.WriteLine();
            }
        }

        public void PrintDVDByNumber(int number)
        {
            DVD dvd = dvds.Find(x => x.DVDNumber == number);

            if (dvd != null)
            {
                dvd.PrintInfo();
            }
            else
            {
                Console.WriteLine("DVD not found!");
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
