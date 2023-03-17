
using Challengers;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Diagnostics;
using System;

// create a new Stopwatch object
Stopwatch stopwatch = new Stopwatch();


#region Challenger 1 - Substring
// Console.WriteLine($" Challenger 1 : {Substring01.LongestSubstring("ABCVKkkVKoiuy", 2)}");
#endregion
#region Challenger 2 - Max Product of 2 Integers
// Console.WriteLine($" Challenger 2 : {MaxProductOf2Int.MaxProduct(new int[] {1,2, 10, 4, 5 })}");
// Console.WriteLine($" Challenger 2 : {MaxProductOf2Int.MinProductOf2IntOptimized_1(new int[] { 1, 5, 3, 4, 2 })}");
#endregion
#region Challenger 3 - Longest Subarray
//var target = 10;
//var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, -1, -5, -4}; 
//Console.WriteLine($" Challenger 3 : {string.Join(",", LongestSubarray.FindLongestSubarrayWithSum(arr, target))}");
//Console.WriteLine($" Challenger 3 opt : {string.Join(",", LongestSubarray.FindLongestSubarrayWithSum_optimized_1(arr, target))}");
#endregion
#region Challenger 4 - PasswordStrengthChecker 
//var response1 = _04___PasswordStrengthChecker.PasswordStrengthChecker("@3$$aqAQ!@##$123****yhyhyAAAAA2545677");
//Console.WriteLine($" Challenger 4 :{JsonConvert.SerializeObject(response1)}");

//var response2 = _04___PasswordStrengthChecker.PasswordStrengthChecker("123aqA");
//Console.WriteLine($" Challenger 4 :{JsonConvert.SerializeObject(response2)}");

//Console.WriteLine($" Challenger 4 opt : { }");
#endregion
#region Challenger 5 - Palindrome Permutation
////Console.WriteLine($" Challenger 5 (racecar)...: {_05____PalindromePermutation.GetPalindromePermutation("racecar")}");
////Console.WriteLine($" Challenger 5 (Amor a Roma)...: {_05____PalindromePermutation.GetPalindromePermutation("Amor a Roma")}");
//Console.WriteLine($" Challenger 5 (opt) (cutecute)...: {_05____PalindromePermutation.IsPalindromePermutation("cutecute")}");

#endregion
#region Challenger 6 - Vowel Count
//Console.WriteLine($" Challenger 6 (Country)...: {_06___VowelCount.GetVowelCount("Country")}");

#endregion
#region Challenger 7 - Anagram Checker 
//Console.WriteLine($" Challenger 7  ('testops', 'opstest')...: {AnagramChecker.AreAnagrams("testops", "opstest")}");
//Console.WriteLine($" Challenger 7  ('dute', 'etdu')...: {AnagramChecker.AreAnagrams("dute", "etdu")}");
//Console.WriteLine($" Challenger 7  ('this time', 'that time')...: {AnagramChecker.AreAnagrams("this time", "that time")}");
#endregion
#region Challenger 8 - FizzBuzz
//FizzBuzz.ShowFizzBuzz();  
#endregion
#region Challenger 9 - Phone Number Formatter
//Console.WriteLine($" Challenger 9  \"123-456-7890\"...: {PhoneNumberFormatter.GetPhoneNumberFormatter("123-456-7890")}");
//Console.WriteLine($" Challenger 9  \"123 456 7890\"...: {PhoneNumberFormatter.GetPhoneNumberFormatter("123 456 7890")}");
//Console.WriteLine($" Challenger 9  \"1234567890\"...: {PhoneNumberFormatter.GetPhoneNumberFormatter("1234567890")}");
//Console.WriteLine($" Challenger 9  \"12-345-67-890\"...: {PhoneNumberFormatter.GetPhoneNumberFormatter("12-345-67-890")}");

//Input: "123-456-7890"
//Output: (123) 456 - 7890

//Input: "123 456 7890"
//Output: (123) 456 - 7890

//Input: "1234567890"
//Output: (123) 456 - 7890

//Input: "12-345-67-890"
//Output: null
#endregion
#region Challenger 10 - Sum of Primes
//Console.WriteLine($" Challenger 10  ...: {SumOfPrimes.GetResult(10)}");
#endregion

#region Challenger 11 - Number Of Words
// Console.WriteLine($" Challenger 11  ...: { NumberOfWords.GetNumberOfWords("This is an app to count the words!")}");
#endregion

#region Challenger 12 - Second Largest Number
//Console.WriteLine($" Challenger 12  ...: {SecondLargestNumber.Get(new int[] { 1, 2, 10, 4, 5 }) }");
#endregion

#region Challenger 13 - Caesar Cipher (Intermediate)
//Console.WriteLine($" Challenger 13 ...: {CaesarCipher.Get("W", 7)}");
////    CaesarCipher.Encrypt("HELLO WORLD", 7);

#endregion

#region Challenger 14 - Binary to Decimal Converter (Easy)
//Console.WriteLine($" Challenger 14 ...: {BinaryToDecimalConverter.Execute("1101")}");

#endregion
#region Challenger 15 - Binary to Decimal Converter (Easy)
//Console.WriteLine($" Challenger 15 ...: {PerfectNumber.IsPerfectNumber(0)}"); // N
//Console.WriteLine($" Challenger 15 ...: {PerfectNumber.IsPerfectNumber(1)}"); // N
//Console.WriteLine($" Challenger 15 ...: {PerfectNumber.IsPerfectNumber(2)}"); // N
//Console.WriteLine($" Challenger 15 ...: {PerfectNumber.IsPerfectNumber(3)}"); // N
//Console.WriteLine($" Challenger 15 ...: {PerfectNumber.IsPerfectNumber(4)}"); // N
//Console.WriteLine($" Challenger 15 ...: {PerfectNumber.IsPerfectNumber(5)}"); // N
//Console.WriteLine($" Challenger 15 ...: {PerfectNumber.IsPerfectNumber(6)}"); // Y
//Console.WriteLine($" Challenger 15 ...: {PerfectNumber.IsPerfectNumber(10)}"); // N
//Console.WriteLine($" Challenger 15 ...: {PerfectNumber.IsPerfectNumber(28)}"); // Y
#endregion

#region Challenger 16 - Reverse Words (Easy)
//var longText = "There are several ways to measure the performance of two different solutions and determine which one is better. " +
//    "Here are some common methods: " +
//    "1. Execution time: You can measure the time it takes for each solution to complete the task. " +
//    "2. You can use the Stopwatch class in C# to measure the execution time of each method." +
//    "3. Memory usage: You can measure the amount of memory each solution uses. You can use a memory profiler tool to analyze the memory " +
//    " usage of each method." +
//    "4. Complexity analysis: You can analyze the time and space complexity of each solution. " +
//    " You can use Big O notation to describe the time and space complexity of each method." +
//    "Testing: You can create a set of test cases that cover different scenarios and run them against each solution. " +
//    "You can compare the results and determine which solution is better in terms of accuracy and correctness." +
//    "By using one or more of these methods, you can measure the performance of different solutions and choose the one " +
//    "that works best for your requirements.";

//// Making the text big 
//longText += longText;
//longText += longText;
//longText += longText;
//longText += longText;
//longText += longText;
//longText += longText;
//longText += longText;

////Console.WriteLine($" Challenger 16 ...: {ReverseWords.GenerateReverseWords(longText)}");
////Console.WriteLine($" Challenger 16 ...: {ReverseWords.ReverseStringOptmized(longText)}");

//Console.WriteLine($"\nChallenger 16 | ReverseWords |");
//stopwatch.Start();
//ReverseWords.GenerateReverseWords(longText);
//stopwatch.Stop();
//Console.WriteLine($"  Memory usage...: {Process.GetCurrentProcess().PrivateMemorySize64 / 1024} Kbytes");
//Console.WriteLine($"  Elapsed time...: {stopwatch.Elapsed.TotalMilliseconds} ms");
//stopwatch.Reset();


//Console.WriteLine($"\nChallenger 16 | ReverseStringOptmized |");
//stopwatch.Start();
//ReverseWords.ReverseStringOptmized(longText);
//stopwatch.Stop();
//Console.WriteLine($"  Memory usage...: {Process.GetCurrentProcess().PrivateMemorySize64 / 1024} Kbytes");
//Console.WriteLine($"  Elapsed time...: {stopwatch.Elapsed.TotalMilliseconds} ms");
//stopwatch.Reset();


#endregion

#region Challenger 17 - Armstrong Number
Console.WriteLine($" Challenger 17 ...: {ArmstrongNumber.IsArmstrongNumber("")}");
Console.WriteLine($" Challenger 17 ...: {ArmstrongNumber.IsArmstrongNumber("0")}");
Console.WriteLine($" Challenger 17 ...: {ArmstrongNumber.IsArmstrongNumber("-1")}");
Console.WriteLine($" Challenger 17 ...: {ArmstrongNumber.IsArmstrongNumber("nop")}");
Console.WriteLine($" Challenger 17 ...: {ArmstrongNumber.IsArmstrongNumber("153")}");
Console.WriteLine($" Challenger 17 ...: {ArmstrongNumber.IsArmstrongNumber("9474")}");
Console.WriteLine($" Challenger 17 ...: {ArmstrongNumber.IsArmstrongNumber("123")}");

Console.WriteLine($" Challenger 17 (opt)...: {ArmstrongNumber.IsArmstrongNumberOptmized(0)}");
Console.WriteLine($" Challenger 17 (opt)...: {ArmstrongNumber.IsArmstrongNumberOptmized(-1)}");
Console.WriteLine($" Challenger 17 (opt)...: {ArmstrongNumber.IsArmstrongNumberOptmized(153)}");
Console.WriteLine($" Challenger 17 (opt)...: {ArmstrongNumber.IsArmstrongNumberOptmized(9474)}");
Console.WriteLine($" Challenger 17 (opt)...: {ArmstrongNumber.IsArmstrongNumberOptmized(123)}");


Example:
///  Input: 153
///  Output: "Armstrong Number" 
///  
///  Input: 9474
///  Output: "Armstrong Number" 
/// 
///  Input: 123
///  Output: "Not Armstrong Number"
///  

#endregion

Console.ReadKey();
