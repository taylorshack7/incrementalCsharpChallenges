/*
------------------------------------------------------------------------------------
Program: Sentence Word Counter
Author: Taylor Shackelford
Description:
    This program reads a full sentence from the user and determines how many times
    each unique word appears in that sentence.

    Steps:
    1. Prompts the user to enter a full sentence.
    2. Converts the sentence to lowercase for consistent comparisons.
    3. Splits the input into an array of words.
    4. Uses nested loops to count how many times each word occurs.
    5. Stores each unique "word - count" pair in an array.
    6. Prints a clean list of results showing each word and its count.

Key Concepts:
    - String manipulation with Split(), ToLower(), and Append().
    - Array traversal using nested for loops.
    - Duplicate prevention using the Contains() method.
    - Dynamic array resizing using Append().ToArray().

Notes:
    This solution intentionally uses arrays instead of dictionaries to strengthen
    understanding of manual data handling and object polymorphism. While i am told 
    Lists<string> is a more dynamic option, my courses in  
    'Free Foundational C# with Microsoft Certification' from freecodecamp revolve 
    around arrays. 
------------------------------------------------------------------------------------
*/

Console.WriteLine("This program counts how many times each word appears in your sentence.\nPlease enter a full sentence: \n");

string userInput = Console.ReadLine()?.ToLower() ?? "";
string[] inputWordArray = userInput.Split();
string[] inputWordCountArray = [];
string word = "";



for (int x = 0; x < inputWordArray.Length; x++)
{
    int count = 0;
    for (int y = 0; y < inputWordArray.Length; y++)
        if (inputWordArray[x] == inputWordArray[y])
        {
            count++;
        }
    word = inputWordArray[x] + " - " + count;
    if (!inputWordCountArray.Contains(word))
    {
        { inputWordCountArray = inputWordCountArray.Append(word).ToArray(); }
    }

}

 //Display results to user
 Console.WriteLine("\nHere are you word counts!");
foreach (string x in inputWordCountArray)
{
    Console.WriteLine(x);
}


