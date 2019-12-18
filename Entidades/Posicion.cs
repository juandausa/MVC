namespace Entidades
{
    public class Posicion
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }

        public Posicion(decimal x, decimal y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
