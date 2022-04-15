using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip_Generator
{
    public class Ship
    {
        public List<Base> list = new List<Base>();
        public void add_module(Base @base)
        {
            list.Add(@base);
        }
    }
}
