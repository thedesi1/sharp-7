
namespace levelup
{
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"X =  {x.ToString()}, Y = {y.ToString()}";
        }

    }
}