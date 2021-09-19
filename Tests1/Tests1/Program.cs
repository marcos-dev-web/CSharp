using System;

// this program is to can verify if an array has
// all of your items equals

// i know that is possible to do that with less code, but it's only to study
namespace Tests1 {
    class Program {
        static void Main() {

            List<int> List1 = new List<int>(new int[] { 10, 10, 10 });

            Console.WriteLine($"List1 is all equal: {List1.ArrayIsEqual()}");

            List<string> List2 = new List<string>();

            Console.WriteLine($"List2 is all equal: {List2.ArrayIsEqual(new string[] { "marcos", "Marcos" })}");

        }
    }
}
