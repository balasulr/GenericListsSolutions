using System;


namespace GenericLists {

    internal class Program {
        // Working with a collection called ints

        static int[] ints = new int[] {
            869,   842,    861,    672,    757,    144,    397,    110,    109,    111,
            104,    348,    551,    624,    141,    887,    792,    395,    281,    737,
            612,    740,    574,    313,    672,    404,    523,    507,    843,    164,
            233,    115,    338,    905,    378,    761,    169,    666,    354,    453,
            501,    469,    406,    948,    417,    149,    909,    334,    321,    645,
            370,    933,    483,    770,    681,    631,    108,    151,    726,    876,
            869,    464,    827,    678,    240,    971,    903,    709,    380,    246,
            733,    915,    503,    474,    445,    866,    152,    447,    560,    387,
            726,    314,    477,    523,    483,    452,    250,    966,    677,    442,
            841,    278,    406,    787,    710,    769,    570,    145,    555,    774
        };

        public static void Main(string[] args) {
            // Initial values:
            int total = 0;
            int max = 0;

            int sum = 0;
            int count = 0;
            int avg = 0;

            // Foreach loop to calculate values
            foreach (int aNbr in ints)
            {
                // Finding the sum of the above collection called ints
                if (aNbr % 2 == 1) {
                    total += aNbr;
                }

                // Finding the largest number in the above collection
                if (aNbr > max) {
                    max = aNbr;
                }

                // Finding the average of the numbers that are evenly divisible by 3
                if (aNbr % 3 == 0) {
                    sum += aNbr;
                    count++;
                }
            }

            Console.WriteLine($"\nThe total is: {total}.\n\n");
            Console.WriteLine($"The largest number is: {max}.\n\n");

            // Calculating the average of the numbers in the collection
            // that are evenly divisible by 3
            avg = sum / count;

            // The output of what the Sum and Count of the Average are:
            Console.WriteLine($"There are {count} numbers that are evenly divisible by 3.\n");

            // Here, printing the average
            Console.WriteLine($"The average of the numbers evenly divisible by 3 is: {avg}.\n\n");

        }

    }

}