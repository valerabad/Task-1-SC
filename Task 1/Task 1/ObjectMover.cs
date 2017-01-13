using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    static class ObjectMover
    {
        public static List<RoomObject> listObjects = new List<RoomObject>(); // in constructor?

        public static void Replace()
        {
            foreach (var item in listObjects)
            {
                item.Move();
            }
           
        }
    }

    
}
