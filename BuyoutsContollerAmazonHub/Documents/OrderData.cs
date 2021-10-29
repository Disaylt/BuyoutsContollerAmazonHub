using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyoutsContollerAmazonHub.Documents
{
    public class OrderData
    {
        [DisplayName("ASIN")]
        public string SKU { get; set; }

        [DisplayName("Количество")]
        public int Amount { get; set; }
        public string OrderId { get; set; }

        [DisplayName("Сессия")]
        public string Session { get; set; }

        [DisplayName("Ключ")]
        public string KeyWord { get; set; }

        [DisplayName("Менеджер")]
        public string Manager { get; set; }

        [DisplayName("Статус")]
        public string Status { get; set; }

        [DisplayName("Выполнен")]
        public bool IsDelte { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public string Descriprion { get; set; }
        public string PhoneNumberQiwi { get; set; }
        public int SlotSimCard { get; set; }
    }
}
