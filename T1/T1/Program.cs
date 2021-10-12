using System;
using System.Threading;

namespace T1 {
    public class Program {
        static void Main() {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            double start = 10;

            var math = new Math(start)
            {
                Number = 20
            };

            Console.WriteLine(math); // 10

            math.Number = 5;

            Console.WriteLine(math); // 5

            math.Increment(10).Increment(10).Increment(10).Decrement(5);

            Console.WriteLine(math); // 30

            Beep(1, 20);
        }

        private static void Beep( int time, int max ) {
            int timer = max * 50;

            if ( (timer - time * 100) > 0 ) {
                timer = max * 50 - (time * 100);
            }
            else {
                timer = time;
            }

            Thread.Sleep(timer);
            Console.Beep();

            if ( time < max ) {
                Beep(time + 1, max);
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("\n\nBooooooooooommmm!!!!!\n\n");
                Console.ResetColor();
            }
        }
    }
}
