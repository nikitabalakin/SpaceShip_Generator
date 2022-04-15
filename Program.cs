
namespace SpaceShip_Generator
{
    public class Program
    {
        enum state
        {
            Выбор,
            Выход
        }

        public static void Main()
        {
            Ship ship = new Ship();

            bool work = true;
            int status = 0;
            int menu = 0;

            while (work)
            {
                if(status == 4)
                {
                    work = false;
                }
                Console.WriteLine("Выберете нужные компоненты");
                Console.WriteLine("1. Броня, Стальная");
                Console.WriteLine("2. Броня, Продвинутые композиты");
                Console.WriteLine("3. ЖИлые каютиы, 1 место.");
                Console.WriteLine("4. Реактор полной переработки");
                Console.WriteLine("5. Субварп двигатель");
                Console.WriteLine("6. Мостик");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    ship.add_module(new Steel_armor());
                    Console.WriteLine("Стальная броня добавлена");
                    status += 1;
                }
                else if(menu == 2)
                {
                    ship.add_module(new Advanced_Compiste());
                    Console.WriteLine("Продвинутая композитная броня добавлена");
                    status += 1;
                }
                else if(menu == 3)
                {
                    ship.add_module(new Living_room());
                    Console.WriteLine("Жилые каюты 1 место добавлено");
                    status += 1;
                }
                else if(menu == 4)
                {
                    ship.add_module(new reactor());
                    Console.WriteLine("Реактор добавлен");
                    status += 1;
                }
                else if(menu == 5)
                {
                    ship.add_module(new SubWarp());
                    Console.WriteLine("Субварп двигатель добавлен");
                    status += 1;
                }
                else if(menu == 6)
                {
                    ship.add_module(new Control_room());
                    Console.WriteLine("Мостик добавлен");
                    status += 1;
                }
                else
                {
                    Console.WriteLine("Только выбранные значения");
                }
            }
            Console.Clear();
            foreach (var item in ship.list)
            {
                Console.Write(item.Name + "\n\r");
                foreach (var data in item.GetData())
                {
                    Console.WriteLine($"{data.Item1}: {data.Item2}");
                }
                Console.WriteLine("----------------");
            }

        }
    }
}