using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersTest
{
    public class Program
    {
        public delegate void primeDel(int x);
        static void Main(string[] args)
        { 
            int sericeStart = 0, sericeEnd = 0;
            bool Status = true;
            Console.WriteLine("Select Serice 1) Print Serice 2) Prime Serice 3) Composite Serice");
            int sericetype = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting number in serice");
            sericeStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ending number in serice");
            sericeEnd = int.Parse(Console.ReadLine());
            Program objProgram = new Program();

            if (sericetype == 1) { Status = objProgram.printDigits(sericeStart, sericeEnd); }
            if (Status)
                Console.WriteLine("Operation Completed \nPress any key to exit");
            else
                Console.WriteLine("Operation Failed \nPress any key to exit");
            Console.ReadKey();

        }
        public bool printDigits(int sericeStart, int sericeEnd)
        {
            try
            {
                Console.WriteLine("Operation Started");
                List<int> digits = new List<int>();
                digits = Enumerable.Range(sericeStart, sericeEnd - sericeStart + 1).ToList();
                for (int i = 0; i < digits.Count; i++)
                {
                    Console.WriteLine(digits[i]);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }      
}
}
