using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /*
     * Delegates are type safe function pointers, that is this holds a reference (pointers) to functions.
     * The signature of delegate must match the signature of function to which it is points to, otherwise you will get a compilation error, 
        That's why delegates are called type safe function pointers.
    
        A delegate is similar to class, you can create instance of it, when you do so, you pass in the function name as parameter to the delegate constructor,
        and it is to that delegate points to.

        Delegate syntax looks very much similar to method with delegate keyword.

     Delegate signature must match the signature of function, all the function following delegate signature will be eligible to call those methods.
         */
    public delegate void PrintMsgPointer(string Msg);
    public class DelegateClass
    {
        public static void printMsg(string Message)
        {
            Console.WriteLine("Message is {0}", Message);
        }

        public static void WhatIsMyName(string Name)
        {
            Console.WriteLine("Your name is : {0}",Name);
        }
    }
}
