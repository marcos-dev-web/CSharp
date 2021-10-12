using System;
using System.Globalization;

namespace Sobrecarga {
    class Program {
        static void Main() {
            string name;
            double price;
            int quantity;
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Preço: ");
            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            quantity = int.Parse(Console.ReadLine());

            var product = new Product(name, price, quantity);

            Console.WriteLine($"\nDados do produto: {product}\n");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            quantity = int.Parse(Console.ReadLine());

            product.AddProducts(quantity);

            Console.WriteLine($"\nDados atualizados: {product}\n");

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            quantity = int.Parse(Console.ReadLine());
            
            product.RemoveProducts(quantity);

            Console.WriteLine($"\nDados atualizados: {product}\n");
        }
    }
}
