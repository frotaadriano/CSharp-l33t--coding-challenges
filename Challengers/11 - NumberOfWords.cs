using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    /*
        Write a program that takes a sentence as input and returns the number of words in the sentence. 
        A word is defined as a sequence of non-space characters.
        For example, if the input sentence is "The quick brown fox jumps over the lazy dog", 
        the program should output 9.
     */
    public static class NumberOfWords
    {
        public static int GetNumberOfWords(string word)
        {
            var countArr = word.Split(' ');
            return countArr.Count();
        }  
    }
}
