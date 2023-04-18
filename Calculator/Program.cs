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
                    /*Loop que solicita 3 entradas do usuário, sendo dois termos e uma operação. Caso já tenha tenha algum valor armazenado,
                    ou escolhido operações de log ou raiz, o usuário fará apenas 1 entrada de número. */
                    for (int i = 0; i < 3; i++)
                    {
                        Console.SetCursorPosition(3, 4);
                        switch (i)
                        {
                            case 0:
                                //Contador zero força o usuário dar entrada com dois números. Contador acima de zero significa usar o resultado do cálculo anterior como o "Number1"
                                //Enquanto as entradas não corresponderem ao tipo correto de entrada, o úsuario ficará preso ao aviso de correção de entrada.
                                if (count == 0)
                                {
                                    while (!double.TryParse(Console.ReadLine(), out n1))
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
                                //Operação "Clean" que zera os registro dos vetores.
                                if (op == "c")
                                {
                                    calc.Clear();
                                    count = 0;
                                    Console.SetCursorPosition(3, 2);
                                    Design.CleanLine(2);
                                    i = -1;
                                }
                                //Operações do tipo Log ou Raiz força o Loop funcionar apenas com 1 termo e 1 operação.
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
                                if (n2 == 0)
                                {
                                    if (op == "/")
                                    {
                                        calc.Clear();
                                        count = 0;
                                        Console.SetCursorPosition(3, 2);
                                        Design.CleanLine(2);
                                        i = -1;
                                        Console.SetCursorPosition(3, 2);
                                        Console.WriteLine("Não é possivel dividir por zero");
                                        Console.ReadKey();
                                        Console.SetCursorPosition(3, 2);
                                        Design.CleanLine(2);
                                    }
                                }
                                break;
                        }
                        //Retorna e limpa a posição do cursor que recebe os valores de entrada.
                        Console.SetCursorPosition(3, 4);
                        Design.CleanLine(2);

                    }
                    calc.Add(new Calculation(n1, op, n2));
                }
                catch { }
                //Resgata e mostra na tela os números e a operação utilzada em uma posição pré-definida.
                Console.SetCursorPosition(3, 2);
                Console.Write(calc[count]);
                //Conta a quantidade de caracteres em um vetor.
                int totalchar = calc[count].ToString().Length;
                // Escreve na tela o resultado solicitado pelo usuário.
                Console.SetCursorPosition(totalchar + 3, 2);
                Design.CleanLine(totalchar + 3);
                Console.SetCursorPosition(totalchar + 4, 2);
                Console.Write(calc[count].Result());
                count += 1;
            }
        }
    }
}
