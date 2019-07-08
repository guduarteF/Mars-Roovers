using System;
using System.Collections.Generic;
using System.Text;

namespace SondaEmMarte
{
    class Direcao
    {
        public char N, S, L, O;

        public char Norte()
        {
            return N = 'N';
        }

        public char Sul()
        {
            return S = 'S';
        }
        public char Leste()
        {
            return L = 'L';
        }
        public char Oeste()
        {
            return O = 'O';
        }
    }
}
