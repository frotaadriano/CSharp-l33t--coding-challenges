using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challengers
{
    public class ValidParentheses
    {
        /// <summary>
        /// 
        /// Challenge Name: Valid Parentheses
        /// Difficult Level: Easy
        /// Description: Given a string of parentheses, write a function to determine if the parentheses are valid.Valid parentheses must follow these rules:
        /// 
        /// 
        /// Open brackets must be closed by the same type of brackets.
        /// Open brackets must be closed in the correct order.
        /// Example:
        /// Input: "()"
        /// Output: true
        /// Input: "()[]{}"
        /// Output: true
        /// 
        /// 
        /// Input: "(]"
        /// Output: false
        /// 
        /// 
        /// Input: "([)]"
        /// Output: false
        /// 
        /// 
        /// Input: "{[]}"
        /// Output: true
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsValid(string text)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in text)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' && (stack.Count == 0 || stack.Pop() != '('))
                {
                    return false;
                }
                else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                {
                    return false;
                }
                else if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
