using System;

class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Einfacher Taschenrechner in C#");
        while (true)
        {
            Console.WriteLine("\nWähle eine Operation:");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Exponentialfunktion (Basis ^ Exponent)");
            Console.WriteLine("6: Wurzelziehen (Grad der Wurzel aus Basis)");
            Console.WriteLine("7: Beenden");
            Console.Write("Auswahl: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 7)
            {
                Console.WriteLine("Programm beendet.");
                break;
            }

            Console.Write("Gib die Basis ein: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = 0;
            double result = 0;

            if (operation == 5 || operation == 6)
            {
                if (operation == 5)
                {
                    Console.Write("Gib den Exponenten ein: ");
                }
                else if (operation == 6)
                {
                    Console.Write("Gib den Grad der Wurzel ein (2 für Quadratwurzel, 3 für Kubikwurzel, etc.): ");
                }
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.Write("Gib die zweite Zahl ein: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division durch 0 ist nicht erlaubt!");
                        continue;
                    }
                    break;
                case 5:
                    result = Math.Pow(num1, num2);
                    break;
                case 6:
                    if (num1 >= 0 && num2 > 0)
                    {
                        result = Math.Pow(num1, 1.0 / num2);
                        Console.WriteLine($"Die {num2}. Wurzel von {num1} ist {result}.");
                    }
                    else
                    {
                        Console.WriteLine("Fehlerhafte Eingabe für Wurzelziehen!");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe");
                    continue;
            }

            if (operation != 6)
            {
                Console.WriteLine($"Ergebnis: {result}");
            }
        }
    }
}
