using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomObject obj = new Desk();
            Room.AddObject(new Desk());
            Room.AddObject(new Chair());
            Room.AddObject(new Dog());

            ObjectMover.Replace();

            //RoomObject desk = new Desk();
            //desk.VirtualMove();

            //RoomObject desk2 = new Chair();
            //desk2.VirtualMove();

            Console.ReadKey();
        }
    }
}
