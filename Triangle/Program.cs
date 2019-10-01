using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        int switchValue = 0;
        static void Main(string[] args)
        {
            Program runProg = new Program();
            runProg.Triangle();
            Console.ReadKey();
        }

        public void Triangle() {
            do {
                Console.WriteLine("1. Enter Triangle Dimensions");
                Console.WriteLine("2. Exit");
                string switchValueString = Console.ReadLine();
                if (int.TryParse(switchValueString, out switchValue) && switchValue > 0 && switchValue < 3)
                {
                    int length=0, breadth=0, height=0;
                    string lengthString = string.Empty;
                    string breadthString = string.Empty;
                    string heightString = string.Empty;
                    switch (switchValue)
                    {
                        case 1:
                            {
                                do
                                {
                                    Console.Write("Enter length : ");
                                    lengthString = Console.ReadLine();
                                } while (!(int.TryParse(lengthString, out length) && length > 0));

                                do
                                {
                                    Console.Write("Enter Breadth : ");
                                    breadthString = Console.ReadLine();
                                } while (!(int.TryParse(breadthString, out breadth) && breadth > 0));

                                do
                                {
                                    Console.Write("Enter Height : ");
                                    heightString = Console.ReadLine();
                                } while (!(int.TryParse(heightString, out height) && height > 0));

                                string decision = TriangleSolver.Analyze(length,breadth,height);
                                Console.WriteLine(decision);
                                break;
                            }
                        case 2:
                            {
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            Console.WriteLine("Invalid choice, Try again!!");
                            break;
                    }
                }
            } while (true);
        }
    }
}
