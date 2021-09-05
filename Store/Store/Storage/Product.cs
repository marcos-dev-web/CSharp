using System;
using System.Globalization;

namespace Store.Storage {
    class Product {

        private string _name;
        private double _price;
        public int Id { get; set; }

        public double Price {
            get => _price; set {
                if ( value > 0 ) {
                    _price = value;
                }
                else {
                    throw new Exception("Product price cannot be 0");
                }
            }
        }

        public string Name {
            get => _name; set {
                if ( value != null ) {
                    if ( value.Length > 0 ) {
                        _name = value;
                    }
                    else {
                        throw new Exception("Product name cannot be empty");
                    }
                }
                else {
                    throw new Exception("Product name cannot be empty");
                }
            }
        }

        public override string ToString() {
            return $"ID: {Id} - {Name} R$ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
