using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassParam
{
    /*
     * Passing parameter mechanism:
     * Passing a value  to a function or a metod is called as
     * passing parameter mechnaism:
     * 
     * What is parameter:
     * Whenever we are passing some value for a method for its functionality
     * from outside we will gor for parameters.
     * 
     * Types of parameters:
     * 
     * Two Types:
     * 1)Formal parameters
     * 2)Actual Parameters.
     * 
     * Formal Parameters"
     * called function parameters is called formal parameters.
     * 
     * Actual Parameters:
     * calling function parameters is called actual parameters.
     */
    class myclass
    {
        internal void Add(int a,int b)//here a and b are called as formal parameter here 
            //add is called as "called function"
        {
            int c = a + b;
            Console.WriteLine("sum is "+c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass obj= new myclass();
            int x = 10;
            int y = 20;
            obj.Add(x,y);//Add is called as calling function and x , y are called
            //actual parameters
            //note: parameters are called as Arguments 
            //c#.net will support 3 types of passing parameter mechanism.
            /*
             * 1)call by value or pass by value
             * 2)call by reference or pass by reference
             * 3)call by out or pass by out.
             */
        }
    }
}
