using System;
using System.Collections.Generic;

namespace Store.Storage {
    class Inventory {

        private List<Product> _products = new List<Product>();

        public void AddProduct( string name, double price ) {
            int id = _products.ToArray().Length;

            Product product = new Product
            {
                Name = name,
                Price = price,
                Id = id
            };

            _products.Add(product);
        }

        public bool DeleteProduct( int id ) {

            foreach ( Product product in _products ) {
                if ( product.Id == id ) {
                    return _products.Remove(product);
                }
            }

            return false;
        }

        public bool EditProductName( int id, string name ) {

            foreach ( Product product in _products ) {
                if ( product.Id == id ) {
                    product.Name = name;
                    return true;
                }
            }

            return false;
        }

        public bool EditProductPrice( int id, double price ) {
            foreach ( Product product in _products ) {
                if ( product.Id == id ) {
                    product.Price = price;
                    return true;
                }
            }

            return false;
        }

        public Product GetProduct( int id ) {

            foreach ( Product product in _products ) {
                if ( product.Id == id ) {
                    return product;
                }
            }

            return null;
        }

        public void ShowProducts() {
            foreach ( Product product in _products ) {
                Console.WriteLine(product);
            }
        }

    }
}
