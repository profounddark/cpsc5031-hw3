using System;

class Substring
{
    public static int SubSearch(string mainString, string subString)
    {
        int current = 0;
        bool foundString = false;

        while ((current < mainString.Length) && !foundString)
        {
            int searchCount = current;
            int subCount = 0;
            while ((searchCount < mainString.Length)
                && (subCount < subString.Length)
                && (mainString[searchCount] == subString[subCount]))
            {
                searchCount++;
                subCount++;
            }
            if (subCount == subString.Length)
            {
                foundString = true;
            }
            current++;
        }

        if (foundString)
        {
            return (current - 1);
        }
        else
        {
            return -1;
        }

    }

    public static void Main(string[] args)
    {
        string[] testString = {
            "Happy happy joy joy",
            "Where is the dog?",
            "fun fun fun",
            "I love coding!"
        };

        string[] testSubs = {
            "happy",
            "cat",
            "fun",
            "Me too!"
        };

        for (int i = 0; i < testString.Length; i++)
        {
            Console.WriteLine("Searching for " + testSubs[i] + " in " + testString[i]);
            Console.WriteLine("Result: " + SubSearch(testString[i], testSubs[i]));
        }


    }
}