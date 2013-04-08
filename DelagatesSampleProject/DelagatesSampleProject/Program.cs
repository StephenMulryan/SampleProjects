using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    
    /// <summary>
    /// Example to show the use of a delegate
    /// </summary>
    class Program
    {
        /// <summary>
        /// Declaration of delegate with method signature defined.
        /// </summary>
        /// <param name="info"> input parameter type</param>
        /// <returns>return type will be a string</returns>
        delegate string Del(string info);

        /// <summary>
        /// Declaring an anonymous method which can be assigned to the delegate.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static string Print(string name) { return "Your name is " + name; }

        static void Main(string[] args)
        {
            // Assign the delegate to the Print method.
            Del d = Print;
            //output what the method has returned through the delegate.
            Console.WriteLine(d("Stephen Mulryan"));
            Console.ReadLine();
            
        }
    }
}
