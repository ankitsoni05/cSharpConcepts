using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingVSMethodHiding
{
    public class baseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Message from base class print");
        }
    }
    public class derivedClass : baseClass
    {
        public override  void Print()
        {
            Console.WriteLine("Message from derived class print");
        }
    }

    public class baseClass1
    {
        public void Print()
        {
            Console.WriteLine("Message from base class print");
        }
    }
    public class derivedClass1 : baseClass1
    {
        public new void Print()
        {
            Console.WriteLine("Message from derived class print");
        }
    }
}
