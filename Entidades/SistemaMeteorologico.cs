using System;
using System.Collections.Generic;

namespace Entidades
{
    public class SistemaMeteorologico
    {
        public IList<Planeta> Planetas { get; }

        public SistemaMeteorologico(IList<Planeta> planetas)
        {
            this.Planetas = planetas;
        }

        public Clima CalcularMeteorologia(int d)
        {
            if (this.EstanAlineadosConSol(d))
            {
                return Clima.Sequia;
            }

            if (this.EstanEnTriangulo(d))
            {
                if (this.EstanEnTrianguloConMaximoPerimetro(d))
                {
                    return Clima.PicoDeLluvia;
                }

                return Clima.Lluvia;
            }

            return Clima.CondicionesOptimas;
        }

        private bool EstanEnTrianguloConMaximoPerimetro(int d)
        {
            throw new NotImplementedException();
        }

        private bool EstanEnTriangulo(int d)
        {
            throw new NotImplementedException();
        }

        private bool EstanAlineadosConSol(int d)
        {
            throw new NotImplementedException();
        }
    }
}
