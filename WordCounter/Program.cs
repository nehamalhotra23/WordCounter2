using System;
using Word;
using System.Text.RegularExpressions;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Type a Word");
        string inputWord = Console.ReadLine();
        Console.WriteLine("Type a Sentence");
        string inputSentence = Console.ReadLine();
        RepeatWord newWord = new RepeatWord(inputWord, inputSentence);
        Regex regex = new Regex(@"^[0-9]+$");
        Match wordMatch = regex.Match(inputWord);
        Match sentenceMatch = regex.Match(inputSentence);
        int repeats = newWord.CountRepetedWord(); 
        if (wordMatch.Success || sentenceMatch.Success){
         Console.WriteLine("Invalid Input. Please type a word or sentence");
         Main();
        } else if (inputWord.Contains(" ")) {
          Console.WriteLine("You can only search for one word");
          Main();
        } else {
          Console.WriteLine("Number of match availabe " + repeats);
        }
    }
}