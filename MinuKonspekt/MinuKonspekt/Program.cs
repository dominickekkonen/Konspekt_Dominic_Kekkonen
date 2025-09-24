namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Tere kasutaja, mis on sinu nimi");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }
            else if (nimi != "")
            {
                Console.WriteLine("Tere " + nimi + "!");
            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }

            Console.WriteLine(nimi + ", mis on sinu vanus?: ");
            int kasutajavanus = int.Parse(Console.ReadLine());
            //if (kasutajavanus > 0)
            //{
            //    if (kasutajavanus < 18)
            //    {
            //        Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😒");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Saad osta Monsterit");
            //    }
            //}
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma 😒");
            }
            else
            {
                Console.WriteLine("Saad osta Monsterit");
            }
            Console.WriteLine("Sisesta oma pikkus ka, palun, " + nimi + ":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("Oled  juntsu");  
            }
            else if (pikkus <1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("Oled peaaegu allameetrimees");
            }
            else if (pikkus <1.50d && pikkus >1.25d)
            {
                Console.WriteLine("Oioi, enam ei olegi "+nimi+" !");
            }
            else if (pikkus <1.75d && pikkus >1.50d)
            {
                Console.WriteLine("Oled ennasti standardpikkuses, kui mitte just natuke lühike");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepiita ära ei löö");
            }
            else if (pikkus > 2.00d)
            {
                Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad?");
            }
            else
            {
                Console.WriteLine("pikkust ei tunta");
            }
            //3 kalkulator
            Console.WriteLine("Tere. Sisesta esimine liidetav arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tere. Sisesta esimine liidetav arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta tehtemärk: / * + -");
            string tehteyyp = Console.ReadLine();

            int tulemus = 0;
            if (tehteyyp == "+") 
            {
                tulemus = arv1 + arv2;

            }
            else if (tehteyyp == "-")
            {
                tulemus = arv1 - arv2;
            }
            else if (tehteyyp == "/")
            {
                tulemus = arv1 / arv2;
            }
            else if (tehteyyp == "*")
            {
                Math.Pow(arv1, arv2);
            }
            else
            {
                Console.WriteLine("Palun sisesta tehe, mida kalkulator tuvasta oskab");
            }
            if (tulemus != 0)
            {
                Console.WriteLine(tulemus);
            }
            else
            {
                Console.WriteLine("Tulemus on 0, või üristasid teha tehet, mida kalkulator ei tunne");
            }

            //4 parool
            Console.WriteLine("Programmi edasiseks tööks sisesta palun parool:");
            string password = Console.ReadLine();

            if (password == "shabolda")
            {
                Console.WriteLine("Parool on õige, aarete laegas avaned");
            }
            else if (password == "saatana" || password == "4321")
            {
                Console.WriteLine("Parool on sobimatu, palun mingi muu");
            }
            else
            {
                Console.WriteLine("Parool on vale, proovi uuesti");
            }
            //5 värvituvastus
            Console.WriteLine("Miline värv sulle kõige rohkem meeldib?:");
            string favouriteColour = Console.ReadLine();
            if(favouriteColour == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if(favouriteColour == "oranz")
            {
                Console.WriteLine("Kahjuks oranzi ei ole");
            }
            if(favouriteColour == "kollane")
            {
                Console.BackgroundColor= ConsoleColor.Yellow;
            }
            if (favouriteColour == "roheline")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.WriteLine("Värvi ei tunne");
            }
            Console.WriteLine("värv muudetud");
        }

    }
}
