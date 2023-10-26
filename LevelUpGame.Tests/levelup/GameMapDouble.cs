using levelup;

public class GameMapDouble : GameMap
{
    public Position stubbedPosition = new Position(3,4);
    public Position? startingPosition { get; set; }
        public GameMapDouble()
        {
        }

        //public override Position CalculateNewPosition(Position currentPosition, GameController.DIRECTION direction)
        //{
        //    return stubbedPosition;
        //}

}