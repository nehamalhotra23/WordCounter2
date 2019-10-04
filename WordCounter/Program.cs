using System;
using Word;
using System.Text.RegularExpressions;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Type a word");
        string inputWord = Console.ReadLine();
        Console.WriteLine("Type a sentence");
        string inputSentence = Console.ReadLine();
        RepeatWord newWord = new RepeatWord(inputWord, inputSentence);
        Regex regex = new Regex(@"^[0-9]+$");
        Match wordMatch = regex.Match(inputWord);
        Match sentenceMatch = regex.Match(inputSentence);
        int repeats = newWord.CountRepetedWord(); 
        if (wordMatch.Success && sentenceMatch.Success){
         Console.WriteLine("Invalid Input. Please type a word or sentence");
         Main();

        } else {
          Console.WriteLine("Number of match availabe " + repeats);
        }
    }
}