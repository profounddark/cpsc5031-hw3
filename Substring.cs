using System;

class Substring
{
    public static int SubSearch(string mainString, string subString)
    {
        int current = 0;

        // consider implement without this bool
        bool foundString = false;

        // loop until end of string or until substring found
        while ((current < mainString.Length) && !foundString)
        {
            int searchCount = current;
            int subCount = 0;

            // second loop checking string to substring at current character
            while ((searchCount < mainString.Length)
                && (subCount < subString.Length)
                && (mainString[searchCount] == subString[subCount]))
            {
                searchCount++;
                subCount++;
            }
            // if it got to the end, the substring matches
            if (subCount == subString.Length)
            {
                foundString = true;
                // return current;
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

        // return -1;

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