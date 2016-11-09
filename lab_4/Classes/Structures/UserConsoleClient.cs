using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    struct UserConsoleClient
    {
        private Game game;
        private ConsoleUtil console;

        private void newGame(int x, int y)
        {
            Map map = new Map(x, y);
            game = new Game(map);
            console = new ConsoleUtil();
        }

        private void go()
        {
            while (true)
            {
                console.say("\n--- Ресурси ---\n" + game.getResourceList() + "\n--- Карта ---\n" + game.getMap());
                String[] array = getArray(console.you());
                if (array.Length < 1)
                {
                    game.skip();
                    continue;
                }
                switch (array[0])
                {
                    case "create":
                    case "створити":
                        if (array.Length < 4)
                        {
                            console.error("Мало аргументів");
                        }
                        try
                        {
                            MapObject obj = getMapObject(array[1]);
                            int x = Int32.Parse(array[2]);
                            int y = Int32.Parse(array[3]);
                            if (obj == null)
                            {
                                console.error("Невідомий об'єкт");
                                break;
                            }
                            game.create(obj, x, y);
                        }
                        catch (FormatException ex)
                        {
                            console.error("Вводьте числа для координат");
                        }
                        break;
                    case "skip":
                    case "пропустити":
                        game.skip();
                        break;
                    case "exit":
                    case "вихід":
                        console.say("бувай");
                        return;
                    default:
                        console.error("Незрозуміла команда");
                        break;
                }
            }
        }
        
        private MapObject getMapObject(String s)
        {
            switch (s)
            {
                case "tree":
                case "дерево":
                    return new Relief(ReliefType.Tree);
                case "warehouse":
                case "склад":
                    return new Build(BuildType.Warehouse);
                case "forester":
                case "лісник":
                    return new Build(BuildType.Forester);
                default:
                    return null;
            }
        }
        
        private String[] getArray(String command)
        {
            List<string> list = new List<string>();
            StringBuilder buffer = new StringBuilder();
            foreach (char c in command.ToCharArray())
            {
                if (c == ' ')
                {
                    list.Add(buffer.ToString());
                    buffer = new StringBuilder();
                }
                else
                {
                    buffer.Append(c);
                }
            }
            if (buffer.Length != 0)
            {
                list.Add(buffer.ToString());
            }
            return list.ToArray();
        }

        private class ConsoleUtil {

            public String you()
            {
                Console.Write("you> ");
                return Console.ReadLine();
            }

            public void error(String str)
            {
                Console.Write("error> " + str);
            }

            public void say(String str)
            {
                Console.Write("system> " + str);
            }

        }




        public static void Main(String[] args)
        {
            UserConsoleClient client = new UserConsoleClient();
            client.newGame(5, 5);
            client.go();
        }

    }

}
