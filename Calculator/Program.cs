using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Calculation> calc = new List<Calculation>();
            double n1 = 0; double n2 = 0;
            string op = "";

            Design.Construção();
            int count = 0;

            while (op != "s")
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.SetCursorPosition(3, 4);
                        switch (i)
                        {
                            case 0:
                                if (count == 0)
                                {
                                    while(!double.TryParse(Console.ReadLine(), out n1))
                                    {
                                        CaracterLimit.InputTypeLimit("nu");
                                    }                                    
                                }
                                else
                                {
                                    n1 = calc[count - 1].Result();
                                }
                                break;
                            case 1:                        
                                while (!CaracterLimit.ContainsOnlyAllowedOps(op = CaracterLimit.ReadLine(1)))
                                {
                                    CaracterLimit.InputTypeLimit("op");
                                }
                                if(op == "c")
                                {
                                    calc.Clear();
                                    count = 0;
                                    Console.SetCursorPosition(3, 2);
                                    Console.Write("                         ");
                                    i = -1;
                                }
                                if (op == "l" || op == "r")
                                {                                   
                                    i = 3;
                                }
                                break;

                            case 2:
                                while (!double.TryParse(Console.ReadLine(), out n2))
                                {
                                    CaracterLimit.InputTypeLimit("nu");
                                }
                                break;
                        }
                        Console.SetCursorPosition(3, 4);
                        Console.Write("                         ");

                    }
                    calc.Add(new Calculation(n1, op, n2));
                }
                catch { }
                //Resgata e mostra na tela os números e a operação utilzada.
                Console.SetCursorPosition(3, 2);
                Console.Write(calc[count]);
                int totalchar = calc[count].ToString().Length;
                // Escreve na tela o resultado desejado.
                Console.SetCursorPosition(totalchar + 3, 2);
                Console.Write("                         ");
                Console.SetCursorPosition(totalchar + 4, 2);
                Console.Write(calc[count].Result().ToString("0.########"));
                count += 1;
            }
        }
    }
}
