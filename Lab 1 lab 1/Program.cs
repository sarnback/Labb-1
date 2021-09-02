using System;

namespace Lab_1_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt ::::");
            string userInput = Console.ReadLine();
            Console.Clear();
            string highlightPrint = " ";
            string firstIndexPrint = " ";
            string secondIndexPrint = " ";
            long sum = 0;
            for (int j = 0; j < userInput.Length; j++)
            {
                if (char.IsDigit(userInput[j]))
                {
                    for (int i = j + 1; i < userInput.Length; i++)
                    {
                        if (!char.IsDigit(userInput[i]))
                        {
                            break;
                        }
                        else if (userInput[i] == userInput[j])
                        {
                            highlightPrint = userInput.Substring(j, i - j + 1);
                            long result;
                            long.TryParse(highlightPrint, out result);
                            sum += result;
                            firstIndexPrint = userInput.Substring(0, userInput.IndexOf(highlightPrint));
                            secondIndexPrint = userInput.Substring(highlightPrint.Length + firstIndexPrint.Length, (userInput.Length) - (highlightPrint.Length + firstIndexPrint.Length));
                            Console.Write(firstIndexPrint);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(highlightPrint);
                            Console.ResetColor();
                            Console.WriteLine(secondIndexPrint);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.Write("TOTAL SUMMA = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(sum);
            Console.ResetColor();
        }
    }
}
