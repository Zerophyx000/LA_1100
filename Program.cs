using System.Linq.Expressions;
using System.Reflection.Emit;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ___              _               _ _              _               ___                             _            \r\n| . \\ ___ ._ _  _| | ___ ._ _ _  | \\ | _ _ ._ _ _ | |_  ___  _ _  /  _>  ___ ._ _  ___  _ _  ___ _| |_ ___  _ _ \r\n|   /<_> || ' |/ . |/ . \\| ' ' | |   || | || ' ' || . \\/ ._>| '_> | <_/\\/ ._>| ' |/ ._>| '_><_> | | | / . \\| '_>\r\n|_\\_\\<___||_|_|\\___|\\___/|_|_|_| |_\\_|`___||_|_|_||___/\\___.|_|   `____/\\___.|_|_|\\___.|_|  <___| |_| \\___/|_|  \r\n                                                                                                                \n\n");Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine(" ____                                     __      ____    __  __  ______  ____    ____        __      __               __                                 __     \r\n/\\  _`\\                                  /\\ \\    /\\  _`\\ /\\ \\/\\ \\/\\__  _\\/\\  _`\\ /\\  _`\\     /\\ \\    /\\ \\__           /\\ \\                     __        /\\ \\    \r\n\\ \\ \\L\\ \\_ __    __    ____    ____      \\ \\ \\   \\ \\ \\L\\_\\ \\ `\\\\ \\/_/\\ \\/\\ \\ \\L\\_\\ \\ \\L\\ \\   \\ \\ \\   \\ \\ ,_\\   ___    \\ \\ \\____     __     __ /\\_\\    ___\\ \\ \\   \r\n \\ \\ ,__/\\`'__\\/'__`\\ /',__\\  /',__\\      \\ \\ \\   \\ \\  _\\L\\ \\ , ` \\ \\ \\ \\ \\ \\  _\\L\\ \\ ,  /    \\ \\ \\   \\ \\ \\/  / __`\\   \\ \\ '__`\\  /'__`\\ /'_ `\\/\\ \\ /' _ `\\ \\ \\  \r\n  \\ \\ \\/\\ \\ \\//\\  __//\\__, `\\/\\__, `\\      \\ \\ \\   \\ \\ \\L\\ \\ \\ \\`\\ \\ \\ \\ \\ \\ \\ \\L\\ \\ \\ \\\\ \\    \\ \\ \\   \\ \\ \\_/\\ \\L\\ \\   \\ \\ \\L\\ \\/\\  __//\\ \\L\\ \\ \\ \\/\\ \\/\\ \\ \\_\\ \r\n   \\ \\_\\ \\ \\_\\\\ \\____\\/\\____/\\/\\____/       \\ \\ \\   \\ \\____/\\ \\_\\ \\_\\ \\ \\_\\ \\ \\____/\\ \\_\\ \\_\\   \\ \\ \\   \\ \\__\\ \\____/    \\ \\_,__/\\ \\____\\ \\____ \\ \\_\\ \\_\\ \\_\\/\\_\\\r\n    \\/_/  \\/_/ \\/____/\\/___/  \\/___/         \\ \\ \\   \\/___/  \\/_/\\/_/  \\/_/  \\/___/  \\/_/\\/ /    \\ \\ \\   \\/__/\\/___/      \\/___/  \\/____/\\/___L\\ \\/_/\\/_/\\/_/\\/_/\r\n                                              \\ \\_\\                                               \\ \\_\\                                    /\\____/               \r\n                                               \\/_/                                                \\/_/                                    \\_/__/                "); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            Random random = new Random();
            bool weitermachen = true;
            string eingabe;
            bool valid2;
            Int64 GeheimZahl = 0;
            Int64 Maximal = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Modus? [mega easy][easy][normal][hard][extreme][impossible][custom]");
                Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    try
                    {
                        eingabe = Console.ReadLine();
                        if (eingabe == "easy")
                        {
                            GeheimZahl = random.Next(1, 101);
                            Maximal = 100;
                        }
                        else if (eingabe == "normal")
                        {
                            GeheimZahl = random.Next(1, 1001);
                            Maximal = 1000;
                        }
                        else if (eingabe == "hard")
                        {
                            GeheimZahl = random.Next(1, 10001);
                            Maximal = 10000;
                        }
                        else if (eingabe == "extreme")
                        {
                            GeheimZahl = random.Next(1, 100001);
                            Maximal = 100000;
                        }
                        else if (eingabe == "impossible")
                        {
                            GeheimZahl = random.Next(1, 1000001);
                            Maximal = 1000000;
                        }
                        else if (eingabe == "mega easy")
                        {
                            GeheimZahl = random.Next(1, 11);
                            Maximal = 10;
                        }
                        else if (eingabe == "custom")
                        {
                            rword("Geben sie die Maximalzahl ein!", ConsoleColor.Yellow);
                            bool valid3 = false;
                            Int64 custommax = 1;
                            while (!valid3)
                            {
                                try
                                {
                                    custommax = Convert.ToInt64(Console.ReadLine());
                                    if (custommax > 9223372036854775800)
                                    {
                                        throw new Exception();
                                    }
                                    valid3 = true;
                                }
                                catch
                                {
                                    rword("Falsche Eingabe!", ConsoleColor.DarkRed);
                                    valid3 = false;
                                }
                            }
                            Random rnd = new Random();  
                            GeheimZahl = rnd.NextInt64((Int64)1, (custommax + 1));
                            Maximal = custommax;
                        }
                        else
                        {
                            throw new Exception();
                        }
                        valid2 = true;
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Falsche Eingabe!");
                        Console.ForegroundColor = ConsoleColor.White;
                        valid2 = false;
                    }
                }
                while (!valid2);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ich hab mir eine Geheimzahl überlegt, kannst du sie erraten? (1 bis " + Maximal + ")");
                Console.ForegroundColor = ConsoleColor.White;
                Int64 rateversuch = 0;
                Int64 geratet = 0;
                bool valid;
                do
                {
                    try
                    {
                        rateversuch = Convert.ToInt64(Console.ReadLine());
                        if (rateversuch < 1 || rateversuch > Maximal)
                        {
                            throw new Exception();
                        }
                        geratet = geratet + 1;
                        valid = true;
                    }
                    catch
                    {
                        Console.ForegroundColor
                        = ConsoleColor.DarkRed;
                        Console.WriteLine("Falsche Eingabe");
                        valid = false;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (!valid);    // Fehler...?
                do
                {
                    if (rateversuch > GeheimZahl)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Die Geheimzahl ist kleiner als " + rateversuch + "!");
                        Console.ForegroundColor = ConsoleColor.White;
                        do
                        {
                            try
                            {
                                rateversuch = Convert.ToInt64(Console.ReadLine());
                                geratet = geratet + 1;
                            }
                            catch
                            {
                                Console.ForegroundColor
                                = ConsoleColor.DarkRed;
                                Console.WriteLine("Falsche Eingabe");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        while (rateversuch > Maximal || rateversuch < 1);
                    }
                    else
                    if (rateversuch < GeheimZahl)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Die Geheimzahl ist grösser als " + rateversuch + "!");
                        Console.ForegroundColor = ConsoleColor.White;
                        do
                        {
                            try
                            {
                                rateversuch = Convert.ToInt64(Console.ReadLine());
                                geratet = geratet + 1;
                            }
                            catch
                            {
                                Console.ForegroundColor
                                  = ConsoleColor.DarkRed;
                                Console.WriteLine("Falsche Eingabe");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        while (rateversuch > Maximal || rateversuch < 1);
                    }
                }
                while (rateversuch != GeheimZahl);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Richtig geraten! " + GeheimZahl + " war richtig!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Du hast ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(geratet);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-Mal geratet.");
                void rword(string text, ConsoleColor fcolor)
                {
                    ConsoleColor fc = Console.ForegroundColor;
                    Console.ForegroundColor = fcolor;
                    Console.WriteLine(text);
                    Console.ForegroundColor = fc;
                }
                if (Maximal == 10)
                {
                    if (geratet > 5)
                    {
                        rword("Oh nein! du hast zu viel geratet (über 5)! Du hast verloren!", ConsoleColor.Red);
                    }
                    else
                    {
                        rword("Gewonnen! Du hast unter 5 Mal geraten! Gut gemacht!", ConsoleColor.Green);
                    }
                }
                else
                if (Maximal == 100)
                {
                    if (geratet > 11)
                    {
                        rword("Oh nein! du hast zu viel geratet (über 11)! Du hast verloren!", ConsoleColor.Red);
                    }
                    else
                    {
                        rword("Gewonnen! Du hast unter 11 Mal geraten! Gut gemacht!", ConsoleColor.Green);
                    }
                }
                else
                if (Maximal == 1000)
                {
                    if (geratet > 13)
                    {
                        rword("Oh nein! du hast zu viel geratet (über 13)! Du hast verloren!", ConsoleColor.Red);
                    }
                    else
                    {
                        rword("Gewonnen! Du hast unter 13 Mal geraten! Gut gemacht!", ConsoleColor.Green);
                    }
                }
                else
                if (Maximal == 10000)
                {
                    if (geratet > 14)
                    {
                        rword("Oh nein! du hast zu viel geratet (über 14)! Du hast verloren!", ConsoleColor.Red);
                    }
                    else
                    {
                        rword("Gewonnen! Du hast unter 14 Mal geraten! Gut gemacht!", ConsoleColor.Green);
                    }
                }
                else
                if (Maximal == 100000)
                {
                    if (geratet > 15)
                    {
                        rword("Oh nein! du hast zu viel geratet (über 15)! Du hast verloren!", ConsoleColor.Red);
                    }
                    else
                    {
                        rword("Gewonnen! Du hast unter 15 Mal geraten! Gut gemacht!", ConsoleColor.Green);
                    }
                }
                else 
                if (Maximal == 1000000)
                {
                    if (geratet > 15)
                    {
                        rword("Oh nein! du hast zu viel geratet (über 15)! Du hast verloren!", ConsoleColor.Red);
                    }
                    else
                    {
                        rword("Gewonnen! Du hast unter 15 Mal geraten! Gut gemacht!", ConsoleColor.Green);
                    }
                }
                Console.Write("Wollen sie nochmals spielen [ja][nein]?  ");
                Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    try
                    {
                        eingabe = Console.ReadLine();
                        if (eingabe == "ja")
                        {
                            weitermachen = true;
                            valid = true;
                        }
                        else
                        {
                            if (eingabe == "nein")
                            {
                                weitermachen = false;
                                valid = true;
                            }
                            else
                            {
                                valid = false;
                                throw new Exception();
                            }
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor
                        = ConsoleColor.DarkRed;
                        Console.WriteLine("Falsche eingabe");
                        valid = false;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (!valid);
            }  
            while (weitermachen);
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("Bye!");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}


























































































































































































































































































































