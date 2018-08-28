using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus01opgtext
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Stensgaard";

            //StringBuilder sb = new StringBuilder(fornavn);

            //sb.Append(efternavn);

            //Console.WriteLine(sb.ToString());

            string fullName = fornavn + " " + efternavn;

            Console.WriteLine(fullName); // Printer fuld navn.

            Console.WriteLine(fullName.ToUpper()); // Printer fuld navn i uppercase.

            Console.WriteLine(fullName.ToLower()); // Printer fuld navn i lowercase.

            Console.WriteLine(fullName.Substring(12, 5)); // Printer substring af fuld navn - går fra 0 index 12 tegn frem og tager 5 tegnsæt fra string.

            string line = "Opdel \npå\n3 linjer";

            Console.WriteLine(line);

            System.IO.File.WriteAllText(@"C:\WritingToThisFolder\newText.txt", fullName); // Skriver til statisk tekstfil - gem fulde navn i tekst fil og gem.

            Console.ReadLine();
        }
    }
}
