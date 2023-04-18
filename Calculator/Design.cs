using System;

namespace Calculator
{
    public static class Design
    {
        //Desenho externo da Calculadora.
        static void ExternalDesign()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int largura = 37;
            int altura = 20;
            for (int i = 0; i <= altura; i++)
            {
                // Superior
                if (i == 0)
                {
                    Console.Write("╔");
                    for (int j = 0; j <= largura; j++)
                    {
                        Console.Write("═");
                    }
                    Console.WriteLine("╗");
                }
                // Inferior
                else if (i == altura)
                {
                    Console.Write("╚");
                    for (int j = 0; j <= largura; j++)
                    {
                        Console.Write("═");
                    }
                    Console.WriteLine("╝");
                }
                // Laterais
                else
                {
                    for (int j = 0; j <= largura; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write("║");
                        }
                        else if (j > 0 && j < largura)
                        {
                            Console.Write(" ");
                        }
                        else if (j == largura)
                        {
                            Console.WriteLine("  ║");
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Desenho do display da Calculadora.
        static void Display()
        {
            int larguraD = 33;
            int alturaD = 5;
            int PosX = 2;
            int PosY = 1;

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i <= alturaD; i++)
            {
                // Superior
                if (i == 0)
                {
                    Console.SetCursorPosition(PosX, PosY);
                    Console.Write("╔");
                    for (int j = 0; j <= larguraD; j++)
                    {
                        Console.Write("═");
                    }
                    Console.WriteLine("╗");
                }
                // Inferior
                else if (i == alturaD)
                {
                    Console.SetCursorPosition(PosX, alturaD);
                    Console.Write("╚");
                    for (int j = 0; j <= larguraD; j++)
                    {
                        Console.Write("═");
                    }
                    Console.WriteLine("╝");
                }
                // Laterais
                else
                {
                    if (i > 1)
                    {
                        Console.SetCursorPosition(PosX, i);
                        Console.Write("║");
                        for (int j = 0; j <= larguraD; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("║");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }        
        static void Box(int X, int Y, char OP, string nameOP)
        {
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Sem valor armaz.: Nº + Operação + Nº");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("Com valor armaz.: Operação + Nº");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("ATALHOS DE OPERAÇÕES DISPONIVEIS: ");

            //Desenha os botões.
            int alturaC = 2;
            int larguraC = 4;
            int PosX = X;
            int PosY = Y;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(PosX, PosY - 1);
            Console.Write(nameOP);
            for (int i = 0; i <= alturaC; i++)
            {
                // Superior
                if (i == 0)
                {
                    Console.SetCursorPosition(PosX, PosY);
                    Console.Write("╔");
                    for (int j = 0; j <= larguraC; j++)
                    {

                        Console.Write("═");
                    }
                    Console.WriteLine("╗");
                }
                // Inferior
                else if (i == alturaC)
                {
                    Console.SetCursorPosition(PosX, PosY + alturaC);
                    Console.Write("╚");
                    for (int j = 0; j <= larguraC; j++)
                    {
                        Console.Write("═");
                    }
                    Console.WriteLine("╝");
                }
                // Laterais
                else
                {
                    if (i >= 1)
                    {
                        Console.SetCursorPosition(PosX, PosY + i);
                        Console.Write("║");
                        for (int j = 0; j < larguraC; j++)
                        {
                            if (j == larguraC / 2)
                            {
                                Console.Write(OP);
                            }
                            Console.Write(" ");

                        }
                        Console.WriteLine("║");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        //Limpa a linha com base no tamanho do desenho do Display da Calculadora.
        public static void CleanLine(int space)
        {
            for(int i = 1; i <= 36-space; i++)
            {
                Console.Write(" ");
            }
        }
        //Método que desenha o "formato" de calculadora e seus botões.
        public static void Construção()
        {
            ExternalDesign();
            Display();
            Box(4, 12, '+', " SOMA");
            Box(12, 12, '-', "SUBTRA.");
            Box(20, 12, '*', " MULTI.");
            Box(28, 12, '/', " DIVI.");
            Box(4, 17, 'l', "LOG B10");
            Box(12, 17, 'r', " RAIZ.");
            Box(20, 17, 'i', "POTENCI.");
            Box(28, 17, 'C', " LIMPAR");
        }
    }
}
