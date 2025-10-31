using System.ComponentModel.Design;

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




            //# Kolija kalkulaator - Kirjuta programm mis:
            //#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            //#    - olenevalt kasutaja sisestusest küsib ta:
            //#    - - tünni jaoks:
            //#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
            //#    - - - tünni kõrgust
            //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
            //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
            //#    - - kasti jaoks:
            //#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
            //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
            //#    - - - - kui on risttahukas siis küsib kasutajalt:
            //#    - - - - - pikima külje pikkust, 
            //#    - - - - - lühima külje pikkust ja
            //#    - - - - - kasti kõrgust
            //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)

            Console.WriteLine("Sisesta ostusumma");
            double ostusumma = double.Parse(Console.ReadLine());
            if (ostusumma > 100)
            {
                Console.WriteLine("Saad 20% allahindlust!");
            }
            else if (ostusumma < 101 && ostusumma > 50)
            {
                Console.WriteLine("Saad 10% allahinlust!");
            }
            else if (ostusumma < 51 && ostusumma > 20)
            {
                Console.WriteLine("5% allahindlust!");
            }
            else if (ostusumma < 21 && ostusumma > 0)
            {
                Console.WriteLine("Allahinlust ei saa");
            }
            else
            {
                Console.WriteLine("sisestanud on vigane arv");
            }


            //string kasutajanimi = "";
            //do
            //{
            //    Console.WriteLine("palun sisesta oma kasutajanimi: ");
            //    kasutajanimi = Console.ReadLine();
            //} while (kasutajanimi != "user1");
            //Console.WriteLine("pass");
            //if (kasutajanimi == "user1")
            //{
            //    int ruuduSuurus = 0;

            //    do
            //    {
            //        Console.WriteLine("Kui suurt ruutu saada tahad?");
            //        ruuduSuurus = int.Parse(Console.ReadLine());
            //    } while (ruuduSuurus < 0 && ruuduSuurus > 20);

            //    char reaKujund = '#';
            //    string üksRida = "";
            //    int tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        üksRida = üksRida + "_" + reaKujund;
            //        tsükliMuutuja = tsükliMuutuja - 1;
            //    } while (tsükliMuutuja != 0);

            //    tsükliMuutuja = ruuduSuurus;

            //    do
            //    {
            //        Console.WriteLine(üksRida);
            //        tsükliMuutuja -= 1;
            //    } while (tsükliMuutuja != 0);

            //    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
            //}
            /* tingimuslause osad */
            if (true) { }  //kasustud sõna "if" kutsub esile tingimuse, mille tingimus on sulgude vahel, ning millele jargneb
                           //koodiplokk tingimuse täitumisel teostatava koodiga
            else if (true) { } //kaitstud sõnad "else" ja "if" (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus 
                               //on saamamoodi sulgude vahel, ning millele peab eelnema alat kas "if" või teine "else if". Tingimus
                               //ja eelneva tingimuse mittetäitumisel, teostatakse koodiplokki sees olev kood.
            else { } //kaitstud sõna "else" kutsub esile järeltingimuse, millele peab eelnema kas "if" või "else if", ning mille koodiplokki sisu
                     //täidetakse kõikide teiste "if" ja "else if" tingimuse läbikukkumisel.

            int option = 3; // -------
            switch (option) //*switch on kaitstud sõõna alternatiivse tingimuskontrolli jaoks mida saab ef else-if asemel kasutada.
                            //Sulgude vahele käib muutuja nimi, mille põhjal tngimuslik ümberlülitus toimub. Siin silgude vahel 
                            //ei ole tingimuse ise, vaid kõigest kontrollitav muutuja, või omakorda sulgude vajal muu tingimus.
                            //pärast lülitusvalikut tuleb koodiplokk.
            {
                case 1:     //koodiploki sees on erinevad juhtumid, juhtumit sätestatakse sõna "case" abil. antud juhul kontrollitakse, 
                            //kas muutujas "option" on väärtus 1, millele järgneb koolon ":" väljendades tingimuse täitumisel tehtava 
                            //kooditegevuse algust
                    break;  //Kui tegevus on tehtud, väljutakse mitte ainult juhtumist vaid kogu käesoleva case-tingimuslikust kaitstud 
                            //sõnaga "break". Peale breaki on lauselõpumärk ";". 
                            //Juhtumeid võib olla mitmeid, antud juhul on neid kolm kindlalt
                case 2:
                    break;
                case 3:
                    Console.WriteLine(option);
                    break;
                default:    //Default juhtumit täidetakse siis, kui ülejaanud juhtumid ei kirjelda muutujas "option" olevat seisu
                    break;  //Ka default lõppeb sõnaga break
            }

            /* sõne tööristad ja muud tekstiga seotud */
            string alfa = "a\nb";          // \n -> tekitab ühe sõne sisse reamurde, sõne kus on sees üks "\n", omab kahte rida.
            string beta = $"a {alfa} b";   // $  -> lubab kasutada muutjaid loogelise sulgudega otse teksti sees. On variant
                                           //       formateeritud stringist.

            /* Loogilised tehted */

            //&& -> "and" annab positivse vastuse (true) kui tingimused on täidetud, aga kui pole siis annab negativse vastuse (false)
            //|| -> "or"! annab positivse vastuse (true) kui vähemalt üks tingimus on täidetud.
            //Negatiivse vastus (false) on siis kui tingimused on täidmata
            //! -> "not" Tulemus mis muidu tagastaks (true), hÜÜumärgi abil tagastab (false), ja vastupidi

            /* Võrdlusoperatorid */

            // == -> "on võrdne"  Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärkide teise pool
            // oleva objektiga. ei ole sama nagu üks võrdusmärk, üks võrdusmärk omistab, kaks võrdleb.
            // != -> "ei ole võrdne". Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu võrdusmärgi teisel pool
            // olev objekt. Ta võib olla ükskõik mis muul kujul, aga mitte võrreldava objektiga samal kujul. Võrdlusoperaator on
            // kombinatsioon "on võrdne operaatorist, ja loogilisest tehetst 'not'.
            // > -> "on suurem kui". Märgist vasakul pool olev objekty peaks olema suurem, kui paremal pool olev objekt.
            // < -> "on väiksem kui". Märgist vasakul pool olev objekty peaks olema väiksem, kui paremal pool olev objekt.
            // >= -> "suuremvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem kui parempoolne objekt.
            // Võrdlusoperaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
            // <= -> "väiksemvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem kui parempoolne objekt.
            // Võrdlusoperaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaatoritest.

            /* omistusoperaatorid ja kiirtehted */

            int thing = 1; // = -> üksik võrdusmärk omistab muutuja sisse väärtuse, mida saab kasutada läbi muutuja nime.
            thing += 1;   // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                          // asendab tehet "thing = thing + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest "=".
            thing -= 1;   // -= -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva arvu.
                          // asendab tehet "thing = thing - 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest "=".
            thing *= 2;   // *= -> võrdusmärk mille ees on korrutusmärk "*", automaatselt korrutab muutujasisu, võrdusmärgi teisel pool
                          // oleva arvu kordsi. asendab tehet "thing = thing * 2". on kombinatsioon matemaatilisest tehtest "*" ja
                          // omistamisest "=".
            thing /= 2;   // /= -> võrdusmärk mille ees on jagamismärk "/", automaatselt jagab muutujasisu võrdusmärgi teisel pool oleva
                          // arvu osadeks. asendab tehet "thing = thing / 2". on kombinatsioon matemaatilisest tehtest "/" ja
                          // omistamisest "=".
            thing++;     // ++ -> on spetsiifiliselt ühe juurde liitmiseks kiirthete.
            thing--;     // -- -> on spetsiifiliselt ühe maha lahutamiseks kiirthete.

            /* Tsüklid */
            // 1. do-while
            int dew = 0;
            do   // "do" on kaitstud sõna, mis alustab do-while tsüklit. Pärast seda on koodiplokk {} ning ütleb et tee seda koodi
            {

                dew++;
            } while (dew != 5); //miikaua kuni while järel olevate sulgude vahel tingimus ei täitu, 

            //2. while 
            int i = 1;    //tsüklimuutuja mis aitab järge pidada while tsükli toimimisel
            while (i < 5) ; //"while" on kaitstud sõna mis alustab while tsükli varianti, ilma "do"-ta, ning vajab alati välist
                            //tsüklimuutujat. antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, asub sulgude vahel,
                            //siin kontrollitaksegi tsükli tööd, läbi kindla tingimuse kasutades tsüklimuutjat.
                            //antud juhul tsükkel töötab niikaua, kuni i on väiksem kui 5. kui i on sama suur nagu 5, siis tsükkel 
                            //katkeb.

            //koodiplokk kus midagi tehakse 
            i++;        //ning seejärel muudetakse tsüklimuutuja "i" olekut. antud jahul liidetakse 1 juurde kiirtehtega "++".

            //3. For 
            int kogus = 6;      //muutuja mida tsükkel kasutab oma töö tegemiseks - teisisõnu, töödeldav materjal 
            for (int k = 0; k < 5; k++)     //kaitstud sõna "for" alustab for-tsüklit, pärast mida on sulud, mille vahel on kõik tsükli 
                                            //töö jaoks vajalik olemas. Esimine parameeter, tekitab tsükli töö jaoks kohaliku muutuja 
                                            //"int" k = 0;" mida tsükli ENDA töö juhtmiseks. Teine parameeter on tingimuslause, mis kontrollib 
                                            //tingimuse täitmust "k < kogus;" ning mille täistumisel tsükli töö jatkub, aga mille 
                                            //mitte-täitumisel tsükkel katkeb. Kolmas paraameeter on tsüklimuutuja inkrementeerimine kiirtähtega 
                                            //"k++", Pane tähele, et iga sulgude vahel oleva osa jarel (välja arvatud viimase) on
                                            //lauselõpumark. Tsükli tööd kontrolliv tingimuslause koosneb kolmest reast, mitte ühest 
                                            //nagu "while" või "do-while" puhul. 
                                            //sulgudele järgneb, loodeliste sulgude vahel ole koodiplokk {}
                                            //töötlustegevus tsükli sees, on muutuja "k" hetkearvu väljakuvamine.
            {
                Console.WriteLine(k);
            }

            /* Võimalikud komposiitandmetüübid */
            // 1. massiiv:
            // [] - > Massiiv on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistatakse kantsulgudega.
            //        Massiive saab olla ükskõik millist lihtandmetüüpi massiive.
            //        Massiivi tekitamisel tuleb ära öelda kui pikk või kui suur see massiiv on.
            //        Massiiv ei pea olema koostatud ainult lihtandmetüüpidest, vaid massiive saab olla ka tehtud teistest komposiitandmetüüpidest
            //        Sealhulgas massiiv ise.
            //Esimine tekstiviis:
            int[] arvuMassiiv = new int[5];     // andmetüüp int väljendab, et tegu on täisarvutüüpi andmega
                                                // ja kandilised sulud väljendavad, et tegu on massiiviga.
                                                // Muutuja nimeks on "arvuMassiiv" ja võrdusmärgi abil on
                                                // omistatud muutujasse uus tühi massiiv, kasutades käsku "new",
                                                // millele järgneb massiivi andmetüüp ja pikkuse sätestus "int[3]".
                                                // See tähendab, et siin massiivis on 3 elementi, mis on täisarvud.
            //Teine tekitusviis:
            int[] arvuMassiiv2 = [1, 2, 3];     // Teine massiivi tekitusviis, kus järjendi pikkuse sätestamise asemel
                                                // pannakse elemendid kohe järjendit omava muutujasse sisse.
                                                // Järjendi pikkust sätestama ei pea, kuna pikkuse tuletab kompilaator ise
                                                // elementide arvust (antud juhul 3).
            // -- massiivi sisemised meetodid:
            int hasThisMany = arvuMassiiv.Length; //massiivi meetod "Lenght" mille me saame kasutusele võtta punkti abil, loendab kokku 
                                                  //mittu elementi, adresseritav massiiv omab, omistatakse ainult järjendi pikkus, mitte 
                                                  //järjendi sees olevaid elemente.
        }

    }
}
