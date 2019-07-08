using System;

namespace SondaEmMarte
{
    class Program
    {
        static void Main(string[] args)
        {
            Direcao E;
            E = new Direcao();

            Coordenada C;
            C = new Coordenada();

            int tamanhoTotX;
            int tamanhoTotY;

            int UposInicX;
            int UposInicY;
            char Ucord;
            string Uacoes;

            int DposInicX;
            int DposInicY;
            char Dcord;
            string Dacoes;

            string[] vet = Console.ReadLine().Split(' ');
            tamanhoTotX = int.Parse(vet[0]);
            tamanhoTotY = int.Parse(vet[1]);

            string[] tev = Console.ReadLine().Split(' ');
            UposInicX = int.Parse(tev[0]);
            UposInicY = int.Parse(tev[1]);
            Ucord = char.Parse(tev[2]);

            Uacoes = Console.ReadLine();

            string[] etv = Console.ReadLine().Split(' ');
            DposInicX = int.Parse(etv[0]);
            DposInicY = int.Parse(etv[1]);
            Dcord = char.Parse(etv[2]);


            Dacoes = Console.ReadLine();



            char[] charU = Uacoes.ToCharArray();
            char[] charD = Dacoes.ToCharArray();

            //CHAR D
            for (int i = 0; i < charD.Length; i++)
            {
                switch (charD[i])
                {
                    case 'E':
                        {
                            if (Dcord == 'N')
                            {
                                Dcord = E.Oeste();
                            }
                            else if (Dcord == 'S')
                            {
                                Dcord = E.Leste();
                            }
                            else if (Dcord == 'L')
                            {
                                Dcord = E.Norte();
                            }
                            else
                            {
                                Dcord = E.Sul();
                            }

                        }
                        break;
                    case 'A':
                        {
                            if (Dcord == 'N')
                            {
                                C.DNorte();
                            }
                            else if (Dcord == 'S')
                            {
                                C.DSul();
                            }
                            else if (Dcord == 'L')
                            {
                                C.DLeste();
                            }
                            else
                            {
                                C.DOeste();
                            }
                        }
                        break;

                    case 'D':
                        {
                            if (Dcord == 'N')
                            {
                                Dcord = E.Leste();
                            }
                            else if (Dcord == 'S')
                            {
                                Dcord = E.Oeste();
                            }
                            else if (Dcord == 'L')
                            {
                                Dcord = E.Sul();
                            }
                            else
                            {
                                Dcord = E.Norte();
                            }
                        }
                        break;

                }
            }

            // CHAR U
            for (int i = 0; i < charU.Length; i++)
            {
                switch (charU[i])
                {
                    case 'E':
                        {
                            if (Ucord == 'N')
                            {
                                Ucord = E.Oeste();
                            }
                            else if (Ucord == 'S')
                            {
                                Ucord = E.Leste();
                            }
                            else if (Ucord == 'L')
                            {
                                Ucord = E.Norte();
                            }
                            else
                            {
                                Ucord = E.Sul();
                            }

                        }
                        break;
                    case 'A':
                        {
                            if (Ucord == 'N')
                            {
                                C.Norte();
                            }
                            else if (Ucord == 'S')
                            {
                                C.Sul();
                            }
                            else if (Ucord == 'L')
                            {
                                C.Leste();
                            }
                            else
                            {
                                C.Oeste();
                            }
                        }
                        break;
                    case 'D':
                        {
                            if (Ucord == 'N')
                            {
                                Ucord = E.Leste();
                            }
                            else if (Ucord == 'S')
                            {
                                Ucord = E.Oeste();
                            }
                            else if (Ucord == 'L')
                            {
                                Ucord = E.Sul();
                            }
                            else
                            {
                                Ucord = E.Norte();
                            }
                        }
                        break;

                }
            }



            UposInicX = UposInicX + C.UX;
            UposInicY = UposInicY + C.UY;
            DposInicX = DposInicX + C.DX;
            DposInicY = DposInicY + C.DY;

            Console.WriteLine();

            Console.WriteLine(UposInicX + " " + UposInicY + " " + Ucord);
            Console.WriteLine(DposInicX + " " + DposInicY + " " + Dcord);






        }







    }
}
