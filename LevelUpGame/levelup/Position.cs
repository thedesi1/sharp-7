using System.Drawing;

public class Position
{
    public Point coordinates { get; set; }
    public Position(int xCoordinates, int yCoordinates)
    {
        coordinates = new Point(xCoordinates, yCoordinates);
    }
}