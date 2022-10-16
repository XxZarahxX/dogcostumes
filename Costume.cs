using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostumeShopy
{
    internal class Costume
    {
        public int serial_number;
        public string name;
        public string size;
        public int daily_price;
        public bool rental;

        public Costume(int serial_number, string name, string size, int daily_price, bool rental)
        {
            this.serial_number = serial_number;
            this.name = name;
            this.size = size;
            this.daily_price = daily_price;
            this.rental = rental;
        }
    }
}