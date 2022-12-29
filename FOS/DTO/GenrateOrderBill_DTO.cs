using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.DTO
{
    public class GenrateOrderBill_DTO
    {
        private string _username;
        private string _status;
        private string _itemName;
        private string _totalbill;

        public string ItemName { get => _itemName; set => _itemName = value; }
        public string Totalbill { get => _totalbill; set => _totalbill = value; }
        public string Username { get => _username; set => _username = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
