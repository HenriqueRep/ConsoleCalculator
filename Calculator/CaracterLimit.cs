using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    public static class CaracterLimit
    {
        public static string ReadLine(int maxLength)
        {
            //Método de entrada que limita o usuário em inserir apenas 1 caracter no console. Utilizado na solicitação de entrada de "Operação".
            var line = "";
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && line.Length > 0)
                {
                    line = line.Substring(0, line.Length - 1);
                    Console.Write("\b \b");
                }
                else if (line.Length < maxLength && key.KeyChar >= 32 && key.KeyChar <= 126)
                {
                    line += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }
            return line.ToString();
        }
        //Retorna o aviso que solicita a correção do valor inserido por parte do usuário.
        public static void InputTypeLimit(string type)
        {
            Console.SetCursorPosition(3, 4);
            Console.ForegroundColor = ConsoleColor.Red;
            switch (type)
            {
                case ("nu"): Console.WriteLine("Por favor, insira apenas números!"); break;
                case ("op"): Console.WriteLine("Escolha uma operação abaixo!"); break;
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(3, 4);
            Console.ReadKey();
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("                                 ");
            Console.SetCursorPosition(3, 4);
        }


        public static bool ContainsOnlyAllowedOps(string input)
        {
            string allowedop = "+,-,*,/,l,r,i,c";
            if(string.IsNullOrEmpty(input))
            {
                return false;
            }
            foreach (char c in input)
            {
                if (!allowedop.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
