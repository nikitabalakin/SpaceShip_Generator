using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip_Generator
{
    public class Steel_armor : Base
    {
        bool status = false;
        public Steel_armor()
        {
            Name = "Броня, Стальная";
            Price = 6000;
            Dsp = 1;
        }
        public override List<(string, int)> GetData()
        {
            List<(string, int)> tmp = new List<(string, int)>();
            tmp.Add(("Стоимость ", Price));
            tmp.Add(("Dsp ", Dsp));
            return tmp;
        }
    }

    public class Advanced_Compiste : Base
    {
        bool status = false;
        public Advanced_Compiste()
        {
            Name = "Броня, Продвинутые композиты";
            Price = 60000;
            Dsp = 5;
        }
        public override List<(string, int)> GetData()
        {
            List<(string, int)> tmp = new List<(string, int)>();
            tmp.Add(("Стоимость ", Price));
            tmp.Add(("Dsp ", Dsp));
            return tmp;
        }
    }

    public class Living_room : Base
    {
        public int count;

        public Living_room()
        {
            Name = "Жилые каюты 1 место";
            Price = 100000;
            count = 1;
        }
        public override List<(string, int)> GetData()
        {
            List<(string, int)> tmp = new List<(string, int)>();
            tmp.Add(("Стоимость ", Price));
            tmp.Add(("Экипаж  ", count));
            return tmp;
        }
    }
    public class reactor : React
    {
        public reactor()
        {
            Name = "Реактор полной переработки";
            Price = 2000000;
            need_personal = 0;
            Energy_Output = 5;
            Energy_Input = 1;
        }
        public override void Print_data()
        {
            Console.WriteLine($"Количество вырабываемой энергии {this.Energy_Output}");
            Console.WriteLine($"Количество потребляемой энергии {this.Energy_Input}");
        }

        public override List<(string, int)> GetData()
        {
            List<(string, int)> tmp = new List<(string , int )>();
            tmp.Add(("Количество выробатываемой энергии",Energy_Output));
            tmp.Add(("Количество потребляемой энергии", Energy_Input));
            return tmp;
        }
    }
    public class SubWarp : Dviglo
    {
        public SubWarp()
        {
            Name = "Субварп двигатель";
            Price = 300000;
            need_personal=0;
            energy = 1;
        }
        public override List<(string, int)> GetData()
        {
            List<(string, int)> tmp = new List<(string, int)>();
            tmp.Add(("Стоимость ", Price));
            tmp.Add(("Энергия  ", energy));
            return tmp;
        }
    }

    public class Control_room : Base
    {
        public Control_room()
        {
            Name = "Мостик";
            Price = 60000;
            need_personal = 1;
        }
        public override List<(string, int)> GetData()
        {
            List<(string, int)> tmp = new List<(string, int)>();
            tmp.Add(("Стоимость ", Price));
            tmp.Add(("Нужно экипажа ", need_personal));
            return tmp;
        }
    }
}
