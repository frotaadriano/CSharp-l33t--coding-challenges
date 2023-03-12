
using Challengers;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

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

#region Challenger 9 - 
Console.WriteLine($" Challenger 9  \"123-456-7890\"...: {PhoneNumberFormatter.GetPhoneNumberFormatter("123-456-7890")}");
Console.WriteLine($" Challenger 9  \"123 456 7890\"...: {PhoneNumberFormatter.GetPhoneNumberFormatter("123 456 7890")}");
Console.WriteLine($" Challenger 9  \"1234567890\"...: {PhoneNumberFormatter.GetPhoneNumberFormatter("1234567890")}");
Console.WriteLine($" Challenger 9  \"12-345-67-890\"...: {PhoneNumberFormatter.GetPhoneNumberFormatter("12-345-67-890")}");




//Input: "123-456-7890"
//Output: (123) 456 - 7890

//Input: "123 456 7890"
//Output: (123) 456 - 7890

//Input: "1234567890"
//Output: (123) 456 - 7890

//Input: "12-345-67-890"
//Output: null


#endregion

//#region Challenger 10 - 
//Console.WriteLine($" Challenger 10  ...: { }");

//#endregion

//#region Challenger 11 - 
//Console.WriteLine($" Challenger 11  ...: { }");

//#endregion

Console.ReadKey();
