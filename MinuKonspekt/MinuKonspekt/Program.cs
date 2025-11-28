using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

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
            if (favouriteColour == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (favouriteColour == "oranz")
            {
                Console.WriteLine("Kahjuks oranzi ei ole");
            }
            if (favouriteColour == "kollane")
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


            string kasutajanimi = "";
            do
            {
                Console.WriteLine("palun sisesta oma kasutajanimi: ");
                kasutajanimi = Console.ReadLine();
            } while (kasutajanimi != "user1");
            Console.WriteLine("pass");
            if (kasutajanimi == "user1")
            {
                int ruuduSuurus = 0;

                do
                {
                    Console.WriteLine("Kui suurt ruutu saada tahad?");
                    ruuduSuurus = int.Parse(Console.ReadLine());
                } while (ruuduSuurus < 0 && ruuduSuurus > 20);

                char reaKujund = '#';
                string üksRida = "";
                int tsükliMuutuja = ruuduSuurus;

                do
                {
                    üksRida = üksRida + "_" + reaKujund;
                    tsükliMuutuja = tsükliMuutuja - 1;
                } while (tsükliMuutuja != 0);

                tsükliMuutuja = ruuduSuurus;

                do
                {
                    Console.WriteLine(üksRida);
                    tsükliMuutuja -= 1;
                } while (tsükliMuutuja != 0);

                Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
            }
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
                                                  //4. foreach
            int[] arvuloend = { 3, 67, 420, 69, 42 }; //Massiiv mida foreach kasutab või töötleb mingil kujul
            foreach (var arvInloend in arvuloend) ; //kaitstud sõna foreach alustab foreach tsükli. Pärast mida on sulud, mille vahel tekitatakse 
                                                    //ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev 
                                                    //kaitstud sõna "in" oleva andmekogumi elementi. Tsükli  ei ole 
            //void on andmetüüp, mida muutuja tekitamisel kasutada ei saa. kasutatakse ainult meetodite signatuurides väljendamaks et meetod ei tagasta midagi
            //2. Loend
            //List<T> -> Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend- tüüpi andmeid tähistatakse 
            //           täiendava  andmetüübikirjeldusega "List" mille järel noolsulgudesse <> asetatakse mis tüübi andmed seal loendis on.
            //           Loendi tekitamisel, erinevalt massiivist, ei pea ütlema kui pikk loend on. Loendisse saab dünamiliselt elemente juurde lisada,
            //           ehk tema pikkus ei ole fikseeritud. Sarnaselt massiiviga saab temas hoida ka teisi loendeid.
            // Esimine tekitusviis: 
            List<int> arvunimekiri = new List<int>(); //Andmetüübi kirjeldis "List<>" näidab et tegu on loendiga. Listi noolsulgude <> vahel on loendis 
                                                      //olevate andmete andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve. muutuja enda 
                                                      //nimeks on "arvunimekiri". Omistame sellesse muutujasse kaitstud sõna "new" abil uue tühja 
                                                      //täis arvuloendi sätestusega "List<int>()"
            // Teine tekitusviis:
            List<int> arvunimekiri2 = new List<int>(); //Teine loendi tekitusviis. Andmetüübi kirjeldus "List<>" näiteb et tegu on loendiga, Listi 
                                                       //noolsuigude vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int"
                                                       //mis tähistab täisarve. Muutuja enda nimeks on "arvunimekiri2". Omistame selle muutujasse 
                                                       //kaitstud sõna "new" abil uue täisarvuloendi, aga seekord, peale sätestust "List<int>()" saame 
                                                       //instantseerimise hetkel talle kaasa anda ka esimesi elemente. Antud juhul on need elemendid 
                                                       //1, 2, 3, . Elemendid sisestatakse nimekirja loogelise sulgude vahel. Enam ei ole tegu 
                                                       //tühja nimekirjaga, vaid loendiga kus on kolm elementi juba sees.
            // Kolmas tekitusviis:
            List<int> arvuNimekiri3 = new List<int>(3);  //kolmas loendi tekitusviis. Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi noolsulgude  
                                                         //vahel on loendis olevate elementide andmetüüp. Antud juhul on andmetüübiks "int" mis tähistab täisarve.  
                                                         //Muutuja enda nimeks on "arvulinnkiri". Omistame sellesse muutujasse käivitusseadise "new" abil uue  
                                                         //täisarvuloendi, aga tavalisete sulgude vahele paneme arvu "3". Sarnaselt massiiviga ütleb see, et  
                                                         //loend on 3 elemendi suurune. Loend ise ja tema elemendid on tühjad, aga seal on 3 elementi. Arv "3"  
                                                         //on parameeter mida Listi konstruktor pikkuse määramiseks kasutab. Nimekiri säilitab oma omaduse muuta  
                                                         //pikkust elementide lisamise–eemaldamisega, aga vajadusel saab nii anda talle pikkuse.
            int aa = 9001;
            // -- Loendi sisemised meetodid: 
            arvunimekiri.Add(3); //Loendi meetod "Add()" lisab enne punkti olevale järjendile uue elemendi, element mida lisatakse on Add meetodi sulgude 
                                 //vahel. Elementi saab lisada otse (antud juhul täisarv "3")
            arvunimekiri2.Add(aa); //või muutujana
            int loendipikkus = arvuNimekiri3.Count(); //Loendi meetod "Count()" loeb kokku mitu elementi jaärjendis on, meetod tagastab täisarvu mis vastab 
                                                      //elemendide kogusele.
            bool Kasseearvon = arvuNimekiri3.Contains(3); //Loendi meetod "Contains()" otsib kogu järjendi seest elementi, mis vastab sulgude  vahel olevale 
                                                          //parameetrile. Meetod tagastab kas "true" või "false" - on leitud või ei ole. Tegemist on 
                                                          //põhimõtteliselt Foreach tsükliga, mis otsib kindlat vastet, töötades läbi kogu loendi. 
            arvuNimekiri3.Remove(4); //loendi meetod "Remove()" eemaldab en

            /*Meetodid*/
            //meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid spetsifilisi funktsioone või tegevusi. 
            //Meetodid lasevad programmeerijal taaskasutada oma ellnevalt kirjutatud koodi - write once use many times. 
            //Meetodeid on kahte liiki - Ühed, mis tagastavad mingisuguse töö või tegevuse tagajärel või tulemusena andmeid, ja teised 
            //mis ei tagasta midagi, kuid omavad siiski mingit tegevust.

            //Meetodi signatuur & selle kompositsioon:
            //Meetodi signatuur on kõige esimine rida, mis meetodi tekitamiseks kirjutakse, ning mis kirjeldab meetodidt ennast, ning selle 
            //omadusi. 
            //
            //Meetodi signatuur koosneb mitmest kindlast äramääratud omadusest. Nendeks on juurdepääsu modifikaator, tagastutüüp, 
            //meetodi enda nimi, olenevalt meetodi liigist ka parametrid mis on sulgude vahel (), ning koodiplokkist mis on meetodi sisu.
            //- Juurdpääsu modifikaator ütleb ära, kust ja kuidas seda meetodid välja kutsuda või adresseerida saab. juurdepääsu modifikaatoreid
            // on tähtsamatest 4-5 tükki.
            // 1 - public- meetod on avalik ja kättesaadav ka teistes klassides, peale selle klassi, kus meetod ise asub.
            // 2 - private- meetod on saadav ainult selles klassis kus meetod ise asub 
            // 3 - protected- meetod on saadav ainult selles klassis kus meetod ise asub ja klassis mis pärilusega saab selle klassi andmed kaasa
            // 4 - internal- meetod on saadav ainult selles klassis ja ainult selles failis. 
            // 5 - static- vahest võib olla pandud ka static, see ütleb lihtsalt et see meetod asub siin.

            // - Tagastustüüp on meetodi omadus, mis ütleb ära millise tüübiga andmed meetodi väljakutsumise asukohta tagastatakse, kui üldse. 
            //Andmetüüp, mida tagastada, võib olla ükskõik milline liht- või kombinatsioonandmetüüp. Aga kui meetod ei tagasta üldse andmeid 
            //pannakse selle asemel andmetüübiks "void" . Kui meetodil on tagastustüüp mis on midagi muud kui void, on meetodi sees, iga toimiva 
            //koodisumma lõpus kaitstud sõna "return", return ütleb et, just see asi on vaja tagastada. peale returni on alati mingisugune kindel 
            //muutuja , või tegevuse tulemus, mis tagastatakse meetodi väljakutseasukohta. peale käevitanud returni, ei teostata mitte ühtegi
            //muud meetodis olevat koodi, sest meetod on leidnud oma tagastava objekti, ning meetodi töö sellel hetkel katkestatakse. 
            //Return on osaliselt kui ka break 
            //
            // – Meetodi enda nimi on midgi mille järgi arendaja meetodit kasutab, kutsub koodis välja, ning meetodi nimi peaks kuvama
            // üldsõnaliselt mida see meetod teeb. Näites meetod nimega "A()"; ei ole hea, sest sõna "A" ei ütle programmeerijale mitte midagi.
            // Aga näiteks meetod, nimega "ArvutaArvudKokku();” Ütleb arendajale ära, mida see meetod teeb. Ta ei raiska oma aega, selle
            // meetodi enda koodi lugemisele.
            //
            // – Parameetrid on need, mis ütlevad, mis meetodil tema täaks vaja on. Parameeter, meetodi signatuuris võib olla teistmoodi
            // väljendatud, kui on kirjutatud muutujja mis on koodi sees, mille jaoks seda kasutada vaja on.
            //
            // – 1. tüüpi meetod – ei tagasta midagi:
            
            public static void UusMeetod() //Meetodi signatuur, mis omab juurdepääsumodifikaatorid "public", "static" ütleb et ta kuulub sellesse 
                                           //klassi. Tagastustüüp on "void" mis ütleb et andmeid meie meetod ei tagasta. pärast omadusi on selle 
                                           //meetodi ńimi "UusMeetod" peale mida on sulud, kus parameetreid ei ole. 
                                           //pärast signatuuri on koodiplokk selle meetodi koodiga, loogelise sulgude vahel {}
            {
            Console.WriteLine("Tere");     //Antud juhul on meetodi sisuks sõnumi kuvamine, mooduli "Console" abiga, mille seest punkti abil "."
                                           //adresserime Console meetodid "Writeline" ning mille parametriks on sõne "Tere", paarameter asub 
                                           //peale meetodi mine olevate sulgude vahel. lause lõppeb lauselõpumärgiga ";"
                                           //See arendaja poold kirjutatud meetod rohkem koodi ei oma.

            }

        //2. Tüüpi meetod - tagastab väärtuse: 
        int[] arvutatavadArvud = new int[] { 67, 69, 120, 540, 666 }; //Töödeldavad andmed, mis asuvad täisarvumasiivis, muutujanimega 
                                                                      //"arvutatudArvud".

        public static int ArvutaKokku(int[] arvud)  //Meetod mille signatuuris on juurdepääsumodifikaator "public", "static" ütleb et ta kuulub
                                                    //sellesse klassi, tagastustüüp "int" ütleb, et programmis tagastatakse täisarv asukohata
                                                    //koodis kus meetod algselt välja kutsuti. Siis on meetodi nimi "ArvutaKokku", ning sulgude
                                                    //vahel ootab meetod täisarvumassiivi. Sellele massiivile pannakse meetodi siseselt ajutine
                                                    //nimi "arvud". Meetod ootab esimes parametri asukohal just arvumassiivi olenemata mis
                                                    //tema muutuja nimi on. Peale signatuuri on koodiplokk tehtava koodiga.
        {
            int summa = 0 ; //Tekkitan´me täisarvuandmetüüpi muutuja nimega "summa", kuhu esialgu omistatakse võrgusmärgi abil arv 0. Lause 
                            //lõppeb lauselõpumärgiga ";"
            foreach (var arv in arvud)  //tekitame "foreach" tsükli, mille kogumikuks on meetodisisene arvudemassiiv nimega "arvud", mille 
                                        //iga elemendi ajutakse muutuja mini on "arv"
            {   //peale seda on koodiplokk 
                summa += arv;   //muutujale summa omistatakse += märgiga juurde hetkel tsüklis kasutuseolev arv. asendab tehet summa = summa + arv 
            }
            return summa;   //pärast tsükli töö lõppu on kaitstud sõna "return" mille järel on muutuja "summa", ning tagastatakse täisarv, 
                            //mis asub muutujas summa, meetodi töö lõppeb.

        }

        }
    }    
        
       //string[] konsoolid = { "Playstation 1", "Nintendo WII", "Valve steam machine" };

        //List<string> mängud = new List<string>();

        //string[] konsoolid = { "Playstation 1", "Nintendo WII", "Valve steam machine" };

        //foreach  (var konsool in konsoolid)
        //{
        //    Console.WriteLine(konsool);
        //}

        //for (int i = 0; i < konsoolid.Length; i++)
        //{
        //    Console.WriteLine(konsoolid[i]);
        //}

        //string currentEntry = "";   //ajatine muutuja mis hoiab tekstitüüpi andmeid, hetkel tühi 

        //while (currentEntry == "")  //while tsükkel mis toiib nii kaua kuni currentEntry on tühi
        //{
        //    Console.WriteLine("Sisesta mäng või kirjuta \"ei taha\" kui soovid esitlust lõpetada");
        //    //esitame kasutajale sõnumi 
        //    currentEntry = Console.ReadLine();
        //    //paneme ajutisse muutujasse info kasutajalt
        //    if (currentEntry =="ei taha")   //kui kasutaja kirjutas "ei taha", teeme ifi sisu
        //    {
        //        break;  //break katkestab kogu tsükli, peatades sisestumise
        //    }
        //    mängud.Add(currentEntry);   //lisame loendile otsa kasutaja sisestanud info 
        //    currentEntry = "";  //omistame muutujasse currentEntry uuesti tühja sisestuse, et tsükel jätkuks
        //}

        //Console.WriteLine("\n\n\n");

        //foreach (var mäng in mängud)
        //{
        //    Console.WriteLine(mäng);
        //}
        //        Console.WriteLine("Mis on sinu lemmikvärvid? Sisesta palun ükshaaval\n Kui rohkem värve ei ole, kirjuta \"rohkem pole\"");
        //List<string> kasutajaVärvid = new List<string>();
        //        string sisestus = "";
        //do
        //{
        //    Console.WriteLine("Sisesta 1 värv korraga:");
        //    sisestus = Console.ReadLine();
        //    if (sisestus != "rohkem pole ")
        //    {
        //        kasutajaVärvid.Add(sisestus);
        //    }

        //} while (sisestus != "rohkem pole") ;


        //foreach (var värv in kasutajaVärvid)
        //{
        //    switch (värv)
        //    {
        //        //punane, oranz, kollane, roheline helesinine, tumeroheline, tumesinine, lilla,
        //        //roosa, pruun, must, valge, hall, värvi ei tuna
        //        case "punane":
        //            Console.BackgroundColor = ConsoleColor.Red;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine(">punane");
        //            break;
        //        case "oranz":
        //            Console.BackgroundColor = ConsoleColor.Black;
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine("Kahjuks oranzi ei ole");
        //            break;
        //        case "kollane":
        //            Console.BackgroundColor = ConsoleColor.Yellow;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine(">kollane");
        //            break;
        //        case "roheline":
        //            Console.BackgroundColor = ConsoleColor.Green;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine(">roheline");
        //            break;
        //        case "sinine":
        //            Console.BackgroundColor = ConsoleColor.Blue;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine(">sinine");
        //            break;
        //        case "helesinine":
        //            Console.BackgroundColor = ConsoleColor.Cyan;
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine(">helesinine");
        //            break;
        //        case "tumeroheline":
        //            Console.BackgroundColor = ConsoleColor.DarkGreen;
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine(">tumeroheline");
        //            break;
        //        case "tumesinine":
        //            Console.BackgroundColor = ConsoleColor.DarkBlue;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine(">tumesinine");
        //            break;
        //        case "lilla":
        //            Console.BackgroundColor = ConsoleColor.Magenta;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine(">lilla");
        //            break;
        //        case "roosa":
        //            Console.BackgroundColor = ConsoleColor.Black;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine("Kahjuks roosa ei ole");
        //            break;
        //        case "pruun":
        //            Console.BackgroundColor = ConsoleColor.DarkYellow;
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine(">pruun");
        //            break;
        //        case "must":
        //            Console.BackgroundColor = ConsoleColor.Black;
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine(">tumesinine");
        //            break;
        //        case "valge":
        //            Console.BackgroundColor = ConsoleColor.White;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine(">valge");
        //            break;
        //        case "hall":
        //            Console.BackgroundColor = ConsoleColor.Gray;
        //            Console.ForegroundColor = ConsoleColor.Black;
        //            Console.WriteLine(">hall");
        //            break;
        //        default:
        //            Console.BackgroundColor = ConsoleColor.Black;
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.WriteLine($"Ei tunne sellist värvi{värv}");
        //            break;

            }
}


            
