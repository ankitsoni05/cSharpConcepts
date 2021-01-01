using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool IsBudjetFriendly(Electronics electronics);
    public class Electronics
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public int DevicePrice { get; set; }

        public static void IsBudjetDevice(List<Electronics> electronics,IsBudjetFriendly isBudjetFriendly)
        {
            foreach (Electronics electronic in electronics)
            {
                if (isBudjetFriendly(electronic))
                    Console.WriteLine(electronic.DeviceName + " is budjet device");
                else
                    Console.WriteLine(electronic.DeviceName + " is costly device");
            }
        }

        public static implicit operator List<object>(Electronics v)
        {
            throw new NotImplementedException();
        }
    }
}
