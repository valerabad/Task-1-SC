using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    static public class Room
    {
        static public List<Point> listOfUsedPlace;
        static Room()
        {
            listOfUsedPlace = new List<Point>();
        }

        static public bool PlaceIsFree(Point candidatePlace)
        {          
            if (listOfUsedPlace.Contains(candidatePlace)) return false;
            else
                return true;
        }

        static public void AddObject(RoomObject roomObject)
        {

            if (!listOfUsedPlace.Contains(roomObject.curentPoints))
            {
                listOfUsedPlace.Add(roomObject.curentPoints);                        
            }
            else
            {
                Point newStartPoints;
                do
                {
                    newStartPoints = roomObject.GenerateRandomPlace();
                }
                while (PlaceIsFree(newStartPoints) != true);
                roomObject.curentPoints = newStartPoints;
                listOfUsedPlace.Add(newStartPoints);                
            }
            ObjectMover.listObjects.Add(roomObject);
        }
      
    }
}
