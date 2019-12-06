using System;

namespace AdventDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var n = 0; n < 99; n++)
            {
                for (var v = 0; v < 99; v++)
                {
                    int[] input = 
                    {
                        1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 13, 1, 19, 1, 19, 6, 23, 1, 23, 6, 27, 1, 13,
                        27, 31,
                        2,
                        13, 31, 35, 1, 5, 35, 39, 2, 39, 13, 43, 1, 10, 43, 47, 2, 13, 47, 51, 1, 6, 51, 55, 2, 55, 13,
                        59, 1,
                        59,
                        10, 63, 1, 63, 10, 67, 2, 10, 67, 71, 1, 6, 71, 75, 1, 10, 75, 79, 1, 79, 9, 83, 2, 83, 6, 87,
                        2, 87, 9,
                        91,
                        1, 5, 91, 95, 1, 6, 95, 99, 1, 99, 9, 103, 2, 10, 103, 107, 1, 107, 6, 111, 2, 9, 111, 115, 1,
                        5, 115,
                        119,
                        1, 10, 119, 123, 1, 2, 123, 127, 1, 127, 6, 0, 99, 2, 14, 0, 0
                    };

                    var result = doCalculate(input, n, v);
                    if (result == 19690720)
                    {
                        Console.WriteLine(100 * n + v);
                    }
                }
            }
        }

        public static int doCalculate(int[] inputNumbers, int noun = 12, int verb = 2)
        {
            var currentIndex = 0;
            var shouldContinue = true;
            var hasError = false;
            inputNumbers[1] = noun;
            inputNumbers[2] = verb;
            while (shouldContinue)
            {
                switch (inputNumbers[currentIndex])
                {
                    case 1:
                        if (inputNumbers.Length >= currentIndex + 4)
                        {
                            inputNumbers[inputNumbers[currentIndex + 3]] =
                                inputNumbers[inputNumbers[currentIndex + 1]] +
                                inputNumbers[inputNumbers[currentIndex + 2]];
                            currentIndex += 4;
                        }
                        else
                        {
                            shouldContinue = false;
                        }

                        break;
                    case 2:
                        if (inputNumbers.Length >= currentIndex + 4)
                        {
                            inputNumbers[inputNumbers[currentIndex + 3]] =
                                inputNumbers[inputNumbers[currentIndex + 1]] *
                                inputNumbers[inputNumbers[currentIndex + 2]];
                            currentIndex += 4;
                        }
                        else
                        {
                            shouldContinue = false;
                        }

                        break;
                    case 99:
                        shouldContinue = false;
                        break;
                    default:
                        shouldContinue = false;
                        break;
                }
            }

            return inputNumbers[0];
        }
    }
}