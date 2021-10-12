using System.Globalization;

namespace Sobrecarga {
    class Product {
        public string Name;
        public double Price;
        public double Quantity;

        public Product() {

        }

        public Product( string name, double price ) {
            Name = name;
            Price = price;
            Quantity = 0;
        }

        public Product( string name, double price, int quantity ) : this(name, price) {
            Quantity = quantity;
        }

        public void AddProducts( int quantity ) {
            Quantity += quantity;
        }

        public void RemoveProducts( int quantity ) {
            Quantity -= quantity;
        }

        public double StorageValue() {
            return Quantity * Price;
        }

        public override string ToString() {
            return $"{Name}, $ {Price.ToString("F2", CultureInfo.InvariantCulture)}, {Quantity} unidades, Total: {StorageValue().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
