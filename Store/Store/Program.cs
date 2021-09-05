
using System;
using System.Globalization;

using Store.Storage;

namespace Store {
    class Program {
        private static readonly Inventory Storage = new Inventory();

        static void Main() {
            GetOption();
        }

        private static void NewProduct() {
            string name;
            double price;

            Console.Clear();
            Console.WriteLine("\nNEW PRODUCT\n");

            try {
                Console.Write("Product name: ");
                name = Console.ReadLine();

                Console.Write("Product price: ");
                price = double.Parse(Console.ReadLine());

                Storage.AddProduct(name, price);

                GetOption();
            }
            catch ( Exception err ) {
                Console.WriteLine($"\n[!!] {err.Message}\n");
                Console.ReadKey();
                NewProduct();
            }

        }

        private static void EditProduct() {
            Console.Clear();
            Console.WriteLine("\nEDIT PRODUCT\n");

            Storage.ShowProducts();
            try {
                Console.Write("Product id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Clear();

                Product product = Storage.GetProduct(id);

                Console.WriteLine($"{product}\n");

                Console.Write($"Name [{product.Name}]: ");
                string name = Console.ReadLine();

                Console.Write($"Price [{product.Price.ToString("F2", CultureInfo.InvariantCulture)}]: ");
                string price = Console.ReadLine();

                Storage.EditProductName(id, name.Length > 0 ? name : product.Name);
                Storage.EditProductPrice(id, price.Length > 0 ? double.Parse(price) : product.Price);

                Console.WriteLine("\nProduct updated\n");
                Console.ReadKey();

                GetOption();
            }
            catch ( Exception e ) {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                EditProduct();
            }
        }

        private static void DeleteProduct() {
            int id;

            Console.Clear();
            Console.WriteLine("\nDELETE PRODUCT\n");

            Storage.ShowProducts();

            try {
                Console.Write("Product id: ");
                id = int.Parse(Console.ReadLine());

                if ( Storage.DeleteProduct(id) ) {
                    Console.WriteLine("\nProduct was deleted\n");
                    Console.ReadKey();
                    GetOption();
                }
                else {
                    Console.WriteLine("\nProduct cannot be deleted\n");
                    Console.ReadKey();
                    DeleteProduct();
                }
            }
            catch ( Exception ) {
                Console.WriteLine("\n!! Invalid id (only numbers)\n");
                Console.ReadKey();
                DeleteProduct();
            }

        }

        private static void ShowProducts() {
            Console.Clear();
            Console.WriteLine("\nListing products...\n");
            Storage.ShowProducts();
            Console.WriteLine("\nFinish\n");
            Console.ReadKey();
            GetOption();
        }

        private static void GetOption() {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("1  ) New product");
            Console.WriteLine("2  ) Edit product");
            Console.WriteLine("3  ) Delete product");
            Console.WriteLine("4  ) Show products");
            Console.WriteLine("99 ) Exit");
            Console.Write("> ");

            string option = Console.ReadLine();

            Console.Clear();

            switch ( option ) {
                case "1":
                    NewProduct();
                    break;
                case "2":
                    EditProduct();
                    break;
                case "3":
                    DeleteProduct();
                    break;
                case "4":
                    ShowProducts();
                    break;
                case "99":
                    break;
                default:
                    GetOption();
                    break;
            }
        }
    }
}
