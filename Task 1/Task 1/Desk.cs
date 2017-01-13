using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Desk : RoomObject , IFurniture 
    {
        public override void Move()
        {
            Console.WriteLine("Desk was moved");
            base.MoveBase();
        }
    }
}
