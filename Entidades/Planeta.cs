namespace Entidades
{
    public class Planeta
    {
        public Posicion PosicionInicial { get; set; }
        public decimal VelocidadAngular { get; set; }
        public Posicion Posicion { get; }
        public decimal PosicionAngular { get; set; }

        public Planeta(Posicion posicionInicial, decimal velocidadAngular)
        {
            this.PosicionInicial = posicionInicial;
            this.VelocidadAngular = velocidadAngular;
        }
    }
}
