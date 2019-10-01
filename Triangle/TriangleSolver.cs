using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
   public class TriangleSolver
    {
        public static string Analyze(int length, int breadth, int height) {
            string decision = string.Empty;
            if (length == breadth && breadth == height && length > 0 && breadth > 0 && height > 0)
            {
                decision = "It is Equilateral triangle";
            }
            else if ((length == breadth || breadth == height || length == height) && (length > 0 && breadth > 0 && height > 0))
            {
                decision = "It is Isoceles triangle";
            }
            else if (length != breadth && breadth != height && length > 0 && breadth > 0 && height > 0)
            {
                decision = "It is Scalene triangle";
            }
            else {
                decision = "The values are invalid";
            }
            return decision;
        }
    }
}
