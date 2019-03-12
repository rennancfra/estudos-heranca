using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_proposto.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price,DateTime manufactureDate)
            : base (name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name + "(used)" + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + $"(Manufacture date: {manufactureDate.ToShortDateString()})";
        }
    }
}
