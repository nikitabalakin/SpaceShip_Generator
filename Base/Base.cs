using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip_Generator
{
    public class Base
    {
        public string Name;
        public int Price;
        public int Dsp;
        public int need_personal;
        public virtual void Print_data()
        {

        }

        public virtual List<(string, int)> GetData()
        {
            return null;
        }
    }

    public class React : Base
    {
        public int Energy_Output;
        public int Energy_Input;
    }

    public class Dviglo : Base
    {
        public int speed;
        public int energy;
    }

}
