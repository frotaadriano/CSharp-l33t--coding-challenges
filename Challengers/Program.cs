
using Challengers;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

#region Challenger 1
// Console.WriteLine($" Challenger 1 : {Substring01.LongestSubstring("ABCVKkkVKoiuy", 2)}");
#endregion
#region Challenger 2
// Console.WriteLine($" Challenger 2 : {MaxProductOf2Int.MaxProduct(new int[] {1,2, 10, 4, 5 })}");
// Console.WriteLine($" Challenger 2 : {MaxProductOf2Int.MinProductOf2IntOptimized_1(new int[] { 1, 5, 3, 4, 2 })}");
#endregion
#region Challenger 3
//var target = 10;
//var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, -1, -5, -4}; 
//Console.WriteLine($" Challenger 3 : {string.Join(",", LongestSubarray.FindLongestSubarrayWithSum(arr, target))}");
//Console.WriteLine($" Challenger 3 opt : {string.Join(",", LongestSubarray.FindLongestSubarrayWithSum_optimized_1(arr, target))}");
#endregion

#region Challenger 4 - PasswordStrengthChecker 
var response1 = _04___PasswordStrengthChecker.PasswordStrengthChecker("@3$$aqAQ!@##$123****yhyhyAAAAA2545677");
Console.WriteLine($" Challenger 4 :{JsonConvert.SerializeObject(response1)}");

var response2 = _04___PasswordStrengthChecker.PasswordStrengthChecker("123aqA");
Console.WriteLine($" Challenger 4 :{JsonConvert.SerializeObject(response2)}");

//Console.WriteLine($" Challenger 4 opt : { }");
#endregion

#region Challenger 5 
//Console.WriteLine($" Challenger 5 : { }");
//Console.WriteLine($" Challenger 5 opt : { }");
#endregion

#region Challenger 6 
//Console.WriteLine($" Challenger 6 : { }");
//Console.WriteLine($" Challenger 6 opt : { }");
#endregion

Console.ReadKey();
