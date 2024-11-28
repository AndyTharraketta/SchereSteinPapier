namespace SchereSteinPapier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe
            // Programmieren Sie ein Schere, Stein, Papier Spiel.
            // Der User soll eines der Handzeichen wählen können.
            // Der Computer wählt per Zufall ein eigenes Zeichen. (recherchieren Sie hierzu Random für C#)
            // Dem User wird dann ausgegeben, welches Zeichen der Computer gewählt hat und ob man gewonnen, verloren oder ein Unentschieden hat.
            // Danach kann sich der User entscheiden eine weitere Runde zu spielen, oder nicht.

            AufgabeLang();
            AufgabeKurz();
            static void AufgabeLang()
            {
                //string input;
                //Random rnd = new Random();
                //int computer;
                //bool continueGame;

                //do
                //{
                //    continueGame = false;
                //    Console.Clear();
                //    Console.WriteLine("Hallo User! Wähle PAPIER STEIN oder SCHERE");
                //    input = Console.ReadLine().ToLower().Trim();
                //    computer = rnd.Next(1, 4);

                //    if (input.Equals("papier") || input.Equals("stein") || input.Equals("schere"))
                //    {
                //        if (computer == 1)
                //        {
                //            Console.WriteLine("Computer hat PAPIER gewählt");
                //            if (input.Equals("papier"))
                //            {
                //                Console.WriteLine("Unentschieden!");
                //            }
                //            else if (input.Equals("stein"))
                //            {
                //                Console.WriteLine("Du hast verloren!");
                //            }
                //            else
                //            {
                //                Console.WriteLine("Du hast gewonnen!");
                //            }
                //        }
                //        else if (computer == 2)
                //        {
                //            Console.WriteLine("Computer hat STEIN gewählt");
                //            if (input.Equals("stein"))
                //            {
                //                Console.WriteLine("Unentschieden!");
                //            }
                //            else if (input.Equals("schere"))
                //            {
                //                Console.WriteLine("Du hast verloren!");
                //            }
                //            else
                //            {
                //                Console.WriteLine("Du hast gewonnen!");
                //            }
                //        }
                //        else
                //        {
                //            Console.WriteLine("Computer hat SCHERE gewählt");
                //            if (input.Equals("schere"))
                //            {
                //                Console.WriteLine("Unentschieden!");
                //            }
                //            else if (input.Equals("papier"))
                //            {
                //                Console.WriteLine("Du hast verloren!");
                //            }
                //            else
                //            {
                //                Console.WriteLine("Du hast gewonnen!");
                //            }
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("Eingabe Inkorrekt!");
                //    }

                //    Console.WriteLine("Möchtest du noch eine Runde spielen? J/N");
                //    input = Console.ReadLine().ToLower().Trim();

                //    if (input.Equals("j"))
                //    {
                //        continueGame = true;
                //    }
                //    else
                //    {
                //        continueGame = false;
                //    }
                //}
                //while (continueGame);
            }   // Korrektur in "Lang" mit do while Schleife
            static void AufgabeKurz()
            {
                Random rand = new Random();
                string comOut;

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Hallo user, Bitte gib PAPIER STEIN oder SCHERE ein");
                    string input = Console.ReadLine().ToLower().Trim();
                    int com = rand.Next(1, 4);

                    if (com == 1) comOut = "papier";
                    else if (com == 2) comOut = "stein";
                    else comOut = "schere";

                    if ((input.Equals("papier") && com == 2) || (input.Equals("stein") && com == 3) || (input.Equals("schere") && com == 1))
                    {
                        Console.WriteLine($"Computer hat {comOut} gewählt. Du hast gewonnen.");
                    }
                    else if ((input.Equals("papier") && com == 3) || (input.Equals("stein") && com == 1) || (input.Equals("schere") && com == 2))
                    {
                        Console.WriteLine($"Computer hat {comOut} gewählt.Du hast verloren");
                    }
                    else if ((input.Equals("papier") && com == 1) || (input.Equals("stein") && com == 2) || (input.Equals("schere") && com == 3))
                    {
                        Console.WriteLine($"Computer hat {comOut} gewählt. unentschieden");
                    }
                    else
                    {
                        Console.WriteLine("Eingabe Ungültig!");
                        Console.ReadKey();
                        continue;
                    }

                    Console.WriteLine("Möchtest du noch eine Runde spielen? J/N");
                    if ("j" != Console.ReadLine().ToLower().Trim()) break;

                }





            }   // Korrektur in "Kurz" mit while Schleife




        }
    }
}
