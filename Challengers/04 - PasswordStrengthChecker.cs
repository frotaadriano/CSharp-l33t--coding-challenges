using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Challengers
{
    /// <summary>
    /// Challenge Title: Password Strength Checker
    /// 
    /// Challenge Description: Write a function that takes a password as a string input and returns a score indicating the strength of the password.
    /// 
    /// The score should be a value between 0 and 100, where 0 indicates a very weak password and 100 indicates a very strong password.
    /// 
    /// The function should consider the following criteria when calculating the score:
    /// 
    /// Length: Passwords with more characters receive higher scores.
    /// Complexity: Passwords that contain a combination of uppercase and lowercase letters, numbers, and special characters receive higher scores.
    /// Uniqueness: Passwords that do not contain common words, dictionary words, or personal information receive higher scores.
    /// The function should return the score and a message indicating the strength of the password (e.g. "Very weak", "Weak", "Moderate", "Strong", "Very strong").
    /// 
    /// Example Input: "Password123!$"
    /// Example Output: Score = 95, Strength = "Very strong"
    /// </summary>
    public class _04___PasswordStrengthChecker
    {
        private const double lv0 = 0;
        private const double lv1 = 5;
        private const double lv2 = 25.3;
        private const double lv3 = 25.3;
        private const double lv4 = 33.33;
         

        public static ResponsePWChecker PasswordStrengthChecker(string password)
        {
            double length = GetLength(password);
            double complexity = GetComplexity(password);
            double Uniqueness = GetUniqueness(password);

            var score = length + complexity + Uniqueness;
            var str = GetStrength(score);

            return new ResponsePWChecker
            {
                Score = score,
                Strength = str.ToString()
            }; 
        }

        private static PasswordStrength GetStrength(double score)
        {
            if (score <= 40) return PasswordStrength.VeryWeak;
            else if (score <= 55) return PasswordStrength.Weak;
            else if (score <= 70) return PasswordStrength.Moderate;
            else if (score <= 85) return PasswordStrength.Strong;
            else return PasswordStrength.VeryStrong;

        }

        private static double GetLength(string password)
        {
            if (password.Length <= 1) return lv0;
            else if (password.Length <= 4) return lv1;
            else if (password.Length <= 6) return lv2;
            else if (password.Length <= 10) return lv3;
            else return lv4;
        }

        private static double GetComplexity(string password)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*[0-9]).+$")) return lv4;
            else return lv0;
        }

        private static double GetUniqueness(string password)
        {
            var specialChars = "!@#$%^&*()_\\-+={}[\\]\\|:;\"<>,.?/~`";

            var sum = 0;
            foreach (char c in password)
            {
                if (specialChars.Contains(c))
                {
                    sum++;
                }
            }
            if (sum == 0) return lv1;
            else if (sum == 1) return lv2;
            else if (sum == 2) return lv3;
            else return lv4;
        }



        public static PasswordStrength PasswordStrengthChecker_opt(string password)
        {
            int score = 0;

            if (password.Length < 8)
                return PasswordStrength.Weak;

            if (password.Length >= 8 && password.Length <= 10)
                score++;

            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$"))
                score++;

            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*[0-9]).+$"))
                score++;

            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[!@#$%^&*()_\-+={}[\]\\|:;\""<>,.?/~`]).+$"))
                score++;

            if (score < 2)
                return PasswordStrength.Weak;
            else if (score == 2)
                return PasswordStrength.Moderate;
            else
                return PasswordStrength.Strong;
        }


    }

    public class ResponsePWChecker
    {
        public double Score { get; set; }
        public string? Strength { get; set; }
    }

    public enum PasswordStrength
    {
        [Display(Name = "Very weak")]
        VeryWeak,
        [Display(Name = "Weak")]
        Weak,
        [Display(Name = "Moderate")]
        Moderate,
        [Display(Name = "Strong")]
        Strong,
        [Display(Name = "Very strong")]
        VeryStrong
    }






}
