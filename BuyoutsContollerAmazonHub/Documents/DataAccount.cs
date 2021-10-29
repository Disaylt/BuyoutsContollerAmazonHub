using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyoutsContollerAmazonHub.Documents
{
    public class DataAccount
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public int SimcardSlot { get; set; }
        public string Description { get; set; }
        public bool IsActiveCard { get; set; }
        public string PhoneNumberQiwi { get; set; }
        public string Balance { get; set; }
    }
}
