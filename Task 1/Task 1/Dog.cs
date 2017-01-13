using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Dog : RoomObject, IAnimal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }

        public override void Move()
        {
            Console.WriteLine("Dog was moved");
            base.MoveBase();
        }
    }
}
