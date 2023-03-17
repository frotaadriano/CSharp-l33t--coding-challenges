using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengers
{
    public class BinaryToDecimalConverter
    {
        public static int Execute(string binaryNum)
        {
            if (string.IsNullOrEmpty(binaryNum))
            {
                throw new ArgumentException("Input cannot be null or empty");
            }

            var binaryFactor = 1;
            var result = 0;
            for (int i = binaryNum.Length-1; i >= 0 ; i--)
            {
                char c = binaryNum[i];

                if (c != '0' && c != '1')
                {
                    throw new ArgumentException("Input contains invalid characters");
                }

                result += Convert.ToInt32(binaryNum[i].ToString()) * binaryFactor;
                binaryFactor = binaryFactor * 2;
            }
            return result;
        }
    }
}
