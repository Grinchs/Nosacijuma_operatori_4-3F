using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ievadiet vārdu: ");
        string ievaditaParole = Console.ReadLine();

       
        if (ievaditaParole.Length == 5)
        {
            
            string pareizaParole = "Gatis";

            // Parbauda, vai ievaditais vards sakrit ar defineto paroli
            if (ievaditaParole == pareizaParole)
            {
                Console.WriteLine("Parole ievadīta pareizi");
            }
            else
            {
                Console.WriteLine("Parole ievadīta nepareizi");
            }
        }
        else
        {
            Console.WriteLine("Jābūt 5 simboliem.");
        }
    }
}
