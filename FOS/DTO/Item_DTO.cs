using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.DTO
{
    class Item_DTO
    {
        private string _name;
        private string _price;
        private string _type;

        public Item_DTO()
        {
        }

        public string Name { get => _name; set => _name = value; }
        public string Price { get => _price; set => _price = value; }
        public string Type { get => _type; set => _type = value; }
    }
}
