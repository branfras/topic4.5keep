using System;

namespace topic4._5keep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Brandon Fraser
            Console.WriteLine("What program do you want to run?");
            Console.WriteLine("TV");
            Console.WriteLine("Mouse");
            Console.WriteLine("Pathfinder");
            Console.WriteLine("Knock");
            string pro = Console.ReadLine();
            pro = pro.ToLower();
            if (pro == "tv")
                TV();
            else if (pro == "mouse")
                Mouse();
            else if (pro == "pathfinder")
                Pathfinder();
            else if (pro == "knock")
                Knock();
            else
                Console.WriteLine("That is not one of the listed programs.");

        }


        public static void TV()
        {
            Console.WriteLine("                   o           ");
            Console.WriteLine("           o       /           ");
            Console.WriteLine("            \\     /            ");
            Console.WriteLine("             \\   /             ");
            Console.WriteLine("              \\ /              ");
            Console.WriteLine("+--------------v-------------+ ");
            Console.WriteLine("|  __________________      @ | ");
            Console.WriteLine("| /                  \\       | ");
            Console.WriteLine("| |             ,--, |  (\\)  | ");
            Console.WriteLine("| |       _ ___/ /\\| |       | ");
            Console.WriteLine("| |   ,;`( )__, )  ~ |  (-)  | ");
            Console.WriteLine("| |  // o//   '--;   |       | ");
            Console.WriteLine("| \\  ' o \\     |     / :|||: | ");
            Console.WriteLine("|  -ooo--------------  :|||: | ");
            Console.WriteLine("+----------------------------+ ");
            Console.WriteLine("   []                    []    ");
        }

        public static void Mouse()
        {
            Console.WriteLine(" __           __  ");
            Console.WriteLine("(  `.       ,`  ) ");
            Console.WriteLine(" `.__\\_ _ _/__,'  ");
            Console.WriteLine("    ;(*) (*);     ");
            Console.WriteLine("    ;  \\ /  ;     ");
            Console.WriteLine("     ;  o  ;      ");
            Console.WriteLine(" ,---'.`-','---.  ");
            Console.WriteLine(" |  |  `\"'  |  |  ");
        }

        public static void Pathfinder()
        {
            Console.WriteLine("                                                                    ||");
            Console.WriteLine("                                                  __..--\".          || ");
            Console.WriteLine("                                 __..--\"\"`._..--\"\" . . . .`.        ||");
            Console.WriteLine("                         __..--\"\". . . . . . .`. . . . . . .`.      ||");
            Console.WriteLine("                 __..--\"\". . . . .`. . . . . . .`. . . . . . .`.   //");
            Console.WriteLine("         __..--\"\". . `.  . . . . . .`. . . . . . .`. . . . . . .`.//");
            Console.WriteLine("  _..--\"\"  . . . . . . `.  . . . . . .`. . . . . . .`. . . . . . .||");
            Console.WriteLine(":\". . . .`.  . . . . . . `.  . . . . . .`. . . . . . .`. . . . . .||`.");
            Console.WriteLine("`:. . . . .`.  . . . . . . `.  . . . . . .`. . . . . . .`. . . . .||__>");
            Console.WriteLine("  `:. . . . .`.  . . . . . . `.  . . . . . .`. . . . . . .`.__..-o||");
            Console.WriteLine("    `:. . . . .`.  . . . . . . `.  . . . . . .`. . . . .`;Y\"->.  \"\"");
            Console.WriteLine("      `:. . . . .`.  . . . . . . `.  . . . . . .`. . . __.>.:'");
            Console.WriteLine("        `:. . . . .`.  . . . . . . `.  . . . . __..--\"\" ..+\"`.");
            Console.WriteLine("   _..-._ `:. . . . .`.  . . . . . . `.__..--\"\" ....:::::.|   `.");
            Console.WriteLine(" .\"`` \\_--\" >:. . . . .`.  . . __..,-|\" . ..::::::::::::::`--\"\"-:.");
            Console.WriteLine("' ..`\\J.-  \"8 -`:. . .  __..--\"\"...-I  \\ `. `::::::::::::::::::::\".");
            Console.WriteLine("`/'\\\\88o. ,O \\  `:.--\"\"....:|:::'''`'\\ ='. }-._'::::::::::::::::::|");
            Console.WriteLine("8  8|PP|\"(:. \\-\" \"\"`:::::::|:::.((::='/ .\\\"\" -.:_ ':::::::::::''_.'  _..");
            Console.WriteLine(" 8  8|::/ \\`::Y  _____`:::::|::::.\\\\[ .\\ \" / \"..* *\" -. '''__..--\"\")\\,\"\".-.\\_");
            Console.WriteLine("`\\b d/\"\"===\\==V::.--..__`:::|:::::.|,'*.\"\".:.. \"_ -.*`.\"\"    _.- \"-\"\"\\? \"_ =``.");
            Console.WriteLine("\\\\`\".`\"' .: :-.::.        `:|:::.'.'*.' __..--\"\"   `.*`:--\"\".-\" ?,  .) = \"\"`\\ \\\\");
            Console.WriteLine(" `.``...''_/   ``::      _\\\\--.'.'*.'-\"\"   _..-._ _..>.*;-\"\"@_.-/-\" `\\.-\"\"\"-.\\");
            Console.WriteLine("   `-::--\".- \"@\"}.'.' *.:)     .\"\\` \\ \\`.--'_`-'     `\\. \\-'-\"\"-   `.");
            Console.WriteLine("                     <\\  _...'*.'      .' \\.`\\ `\\ \\\\\"\"         `\\ `' ' .-.\\   |");
            Console.WriteLine("                     _\\\"\".-- - '        -\\. `\\.-\"\"\"-.\\           \\`|    ._)/   '");
            Console.WriteLine("                   .\"\\.`-\"\\`.         `\\. \\-'-\"\"-   `.           \\\\  `---\" / ");
            Console.WriteLine("                 .' \\.`\\ `\\ \\\\        `\\ `' ' .-.\\   |            `.       _/");
            Console.WriteLine("                 -\\. `\\.-\"\"\" -.\\        \\`|    ._) / '              `-..--\"");
            Console.WriteLine("                `\\. \\-'-\"\"-   `.        \\\\  `---\" / ");
            Console.WriteLine("                `\\ `' ' .-.\\   |         `.       _/");
            Console.WriteLine("                 \\`|    ._)/   '           `-..--\"");
            Console.WriteLine("                  \\\\  `---\" / ");
            Console.WriteLine("                   `.       _/");
            Console.WriteLine("                     `-..--\"");
        }

        public static void Knock()
        {
            Console.WriteLine("Knock Knock.");
            string answer = Console.ReadLine();
            Console.WriteLine("Candice.");
            string answe = Console.ReadLine();
            Console.WriteLine("Candice joke get any worse?");

        }
    }
}
