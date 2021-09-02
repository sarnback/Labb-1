using System;

namespace Lab_1_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt ::::");
            string userInput = Console.ReadLine();
            //Rensar konsolen från det användaren har skrivit för syns skull
            Console.Clear();
            string highlightPrint = " ";
            string firstIndexPrint = " ";
            string secondIndexPrint = " ";
            long sum = 0;
            //Yttre for loop börjar på 0 och går igenom string userInput på alla char-index.
            for (int j = 0; j < userInput.Length; j++)
            {
                //Om userInput är ett tal
                if (char.IsDigit(userInput[j]))
                {
                    //Inre for loop som börjar på j+1,alltså ett index före yttre for loop för kunna jämföra två lika tal med varandra.
                    for (int i = j + 1; i < userInput.Length; i++)
                    {
                        //OM det inte är ett tal - break, gå vidare.
                        if (!char.IsDigit(userInput[i]))
                        {
                            break;
                        }
                        //ANNARS OM tal i == tal j 
                        else if (userInput[i] == userInput[j])
                        {
                            //Substring som sparar alla korrekta tal.
                            highlightPrint = userInput.Substring(j, i - j + 1);
                            long result;
                            //Typecastar de sparade stringarna till en long för att kunna skriva ut summan
                            long.TryParse(highlightPrint, out result);
                            sum += result;
                            //Substring som sparar element på index INNANförsta index från highlightPrint
                            firstIndexPrint = userInput.Substring(0, userInput.IndexOf(highlightPrint));
                            //Substring som sparar element på index EFTER de korrekta och firstIndexPrint strängarna.
                            secondIndexPrint = userInput.Substring(highlightPrint.Length + firstIndexPrint.Length);
                            //Skriver ut element INNAN de "korrekta delsträngarna"
                            Console.Write(firstIndexPrint);
                            //Färgar de korrekta delsträngarna till röd
                            Console.ForegroundColor = ConsoleColor.Red;
                            //Skriver ut de korrekta delsträngarna
                            Console.Write(highlightPrint);
                            //Resetar färg till standard
                            Console.ResetColor();
                            //Skriver ut indexvärden efter de korrekta delsträngarna
                            Console.WriteLine(secondIndexPrint);
                            break;
                        }
                    }
                }
            }
            //skriver ut och färgar summan
            Console.WriteLine();
            Console.Write("TOTAL SUMMA = ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(sum);
            Console.ResetColor();
        }
    }
}
