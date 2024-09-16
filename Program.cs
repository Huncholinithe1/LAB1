
{
    {


        {
            string randomNummer = "81575187k62387623593465387469";
            long totalsumman = 0;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Välkommen till matchning!");
            Console.ResetColor();
            // Hitta allamatchande sekvenser
            List<string> matchandeSekvenser = HittaMatchandeSekvenser(randomNummer);
            foreach (var sekvens in matchandeSekvenser)

            {
                Console.Write(randomNummer.Replace(sekvens, ""));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(sekvens);
                Console.ResetColor();

                totalsumman += long.Parse(sekvens);
            }

            //total summa
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Totala summan är = {totalsumman}");
            Console.ResetColor();

            Console.WriteLine("Tryck på valfri tangent för att avsluta");
            Console.ReadKey();
        }

        // Metod som hittar sekvenser som börjar och slutar med samma siffra
        static List<string> HittaMatchandeSekvenser(string input)
        {
            List<string> sekvenser = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    char startSiffra = input[i];

                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[j] == startSiffra && AllaSiffrorMellan(input, i, j))
                        {
                            string matchadSekvens = input.Substring(i, j - i + 1);
                            sekvenser.Add(matchadSekvens);
                            break;
                        }
                    }
                }
            }
            return sekvenser;
        }

        // Kontroll om alla tecken mellan två positioner är siffror
        static bool AllaSiffrorMellan(string input, int start, int slut)
        {
            for (int i = start + 1; i < slut; i++)
            {
                if (!char.IsDigit(input[i]))
                    return false;
            }
            return true;
        }
    }
}