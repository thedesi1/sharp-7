using System.Drawing;
using static levelup.GameController;


namespace levelup
{
    public class GameMap
     
    {
        public readonly int numPosition = 100;

        public int[,] getPositions()
        {
            int[,] matrix = new int[,]
            {
                {0, 1},
                {0, 2},
                {0, 3}
            };
            return matrix;
        }


        // public void calculatePositions(Position startingPosition, DIRECTION direction)
        // {

            
        // }
        public Boolean isPositionValid(Point positionCoordinates)
        {
            return false;
        }

        public int getTotalPositions()
        {
            return 1;
        }
        
    }
    

}