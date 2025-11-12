/*
------------------------------------------------------------------------------------
Program: Sentence Reverser
Author: Taylor Shackelford
Description:
    This program reads a full sentence from the user and reverses the order of the
    words without altering the words themselves.

    Steps:
    1. Prompts the user to enter a full sentence.
    2. Splits the sentence into an array of words.
    3. Loops through the array in reverse order.
    4. Builds a new array that stores the reversed word order.
    5. Prints the reversed sentence back to the user.

Key Concepts:
    - String manipulation with Split().
    - Array indexing and reverse traversal.
    - Manual data rearrangement (no built-in Reverse() used).
    - Reinforces control over array indexing and iteration logic.

Notes:
    This solution intentionally uses arrays instead of lists or LINQ methods 
    to stay aligned with the array-based lessons from 
    'Free Foundational C# with Microsoft Certification' on freeCodeCamp.
------------------------------------------------------------------------------------
*/

Console.WriteLine("This program takes a sentence and reverses it.\nPlease enter a full sentence: \n");

string [] userInput = Console.ReadLine().Split();
//string[] inputWordArray = userInput.Split();
string[] inputWordsReversed = new string [userInput.Length];
int count = 0;


for (int x = userInput.Length - 1; x >= 0; x--)
{
    inputWordsReversed[count] = userInput[x];
    count++;

}

foreach (string x in inputWordsReversed)
{
    Console.Write(x + " ");
}
    
    




