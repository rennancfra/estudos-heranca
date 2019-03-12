using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_proposto.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct()
        {

        }

        public double TotalPrice()
        {
            return Price + customsFee;
        }

        public ImportedProduct(string name, double price,double customsFee)
            : base(name,price)
        {
            this.customsFee = customsFee;
        }

        public override string priceTag()
        {
            return Name +" "+ TotalPrice().ToString("F2",CultureInfo.InvariantCulture) + $" (Customs fee: $ {customsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
