using System;
using System.Collections.Generic;
using System.Text;

namespace SondaEmMarte
{
    class Coordenada
    {
        public int UX;
        public int UY;
        public int DX;
        public int DY;

        public int Norte()
        {
            return UY = UY + 1;

        }

        public int Sul()
        {
            return UY = UY - 1;
        }

        public int Leste()
        {
            return UX = UX + 1;

        }

        public int Oeste()
        {
            return UX = UX - 1;
        }

        // D

        public int DNorte()
        {
            return DY = DY + 1;

        }

        public int DSul()
        {
            return DY = DY - 1;
        }

        public int DLeste()
        {
            return DX = DX + 1;

        }

        public int DOeste()
        {
            return DX = DX - 1;
        }


    }
}
