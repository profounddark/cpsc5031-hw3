using System;

class Knapsack
{
    /// <summary>
    /// Calculate calculates the maximum value, from a list of values given the
    /// associated weights, given a maximum weight. This is an implementation of the
    /// Knapsack Problem using recursion.
    /// </summary>
    /// <param name="weights">the array og weights for the items</param>
    /// <param name="values">the array of values for the items</param>
    /// <param name="weightAvailable">the current weight still available</param>
    /// <param name="item">the first item in the arrays to consider</param>
    /// <returns>the max value of items in the knapsack</returns>
    public static int Calculate(int[] weights, int[] values,
        int weightAvailable, int item = 0)
    {
        // if no more items or the weight availabe is 0 (or less?)
        if ((item >= weights.Length) || (weightAvailable <= 0))
        {
            return 0;
        }
        // if the next item is TOO BIG
        else if ((weightAvailable - weights[item]) < 0)
        {
            // calculate the result, skipping this item
            return Calculate(weights, values, weightAvailable, item + 1);
        }
        // otherwise, try it with the item and not the item
        else
        {
            // return the larger of the value
            return Math.Max(
                // without the item; or
                Calculate(weights, values, weightAvailable, item + 1),
                // with the item
                values[item] + Calculate(weights, values, weightAvailable - weights[item], item + 1)
            );
        }
    }

    /// <summary>
    /// Main is the entry point for the class. It presents the data being used to the user
    /// and then calculates the optimal Knapsack Problem solution.
    /// </summary>
    /// <param name="args">command line arguments, not used here</param>
    public static void Main(string[] args)
    {
        int[] weights = { 7, 3, 4, 5 };
        int[] values = { 42, 12, 40, 25 };

        int maxWeight = 10;

        Console.WriteLine("Calculating max value for Knapsack arrays:");
        for (int i = 0; i < weights.Length; i++)
        {
            Console.WriteLine("Weight: " + weights[i] + ", Value: " + values[i]);
        }
        Console.WriteLine("Knapsack size is: " + maxWeight);

        // Put some whitespace
        Console.Write("\n");

        Console.WriteLine("Maximum value is: " + Calculate(weights, values, maxWeight));


    }
}