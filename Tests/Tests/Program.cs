using System;

namespace Tests {

    class Program {

        static int Sum( params int[] values ) {
            int s = 0;
            for ( int i = 0; i < values.Length; i++ ) {
                s += values[i];
            }

            return s;
        }

        static void Triple( ref int x ) {
            x *= 3;
        }

        static void Double( int value, out int x ) {
            x = value * 2;
        }

        static void Main() {
            int s1 = Sum(10, 0, 10, 2, 3, 5, 20, 34);
            Console.WriteLine(s1);

            int a = 10;

            Triple(ref a);

            Console.WriteLine(a);

            int b = 10;

            Double(b, out int r);

            Console.WriteLine(r);

            string[] names = new string[] { "marcos", "jose", "Joseff" };

            foreach ( string name in names ) {
                Console.WriteLine($"My friend {name}, is very nice");
            }

        }
    }
}
