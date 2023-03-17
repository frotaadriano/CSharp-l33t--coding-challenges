namespace Challengers
{
    /*
    Caesar Cipher is a simple encryption technique that shifts each character in the plaintext message by a fixed number
    of positions down the alphabet. 
    For example:
        If the shift is 3, 
        then the letter 'A' would be encrypted to the letter 'D', 
        the letter 'B' would become the letter 'E', and so on.

    Write a function that takes in a plaintext message and a non-negative integer for the shift value, 
    and returns the encrypted message using the Caesar Cipher.
    Assume that the plaintext message consists of only uppercase letters and spaces. 
    Spaces should be left as is in the encrypted message.
    Example:
    
    Input:
    message = "HELLO WORLD"
    shift = 3
    Output:
    "KHOOR ZRUOG"

    Input:
    When we apply the shift of 7 to the plaintext message "ATTACK AT DAWN", we get:
    A + 7 = H
    T + 7 = A
    T + 7 = A
    A + 7 = H
    C + 7 = J
    K + 7 = R

    7 =
    A + 7 = H
    T + 7 = A
    7 =
    D + 7 = K
    A + 7 = H
    W + 7 = D
    N + 7 = U
     
     */
    public class CaesarCipher
    {
        // TODO: To complete this approach
        public static string Get(string word, int shift)
        {
            var vocab = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Split(",");
            var vocabLen = vocab.Length;
            var encripted = "";

            foreach (char l in word)
            {
                if (char.IsLetter(l))
                {
                    var position = Array.IndexOf(vocab, l);
                    var endOfVocab = position + shift % 26;
                    if (endOfVocab > 0) { }
                    // encripted +=
                }
                else
                {
                    encripted += l;
                } 
                
            } 
              

            return encripted;
        }

        // opt
        public static string Encrypt(string plainText, int shift)
        {
            string cipherText = "";

            // Iterate through each character in the plaintext
            foreach (char c in plainText)
            {
                // Only encrypt alphabetical characters
                if (char.IsLetter(c))
                {
                    // Determine the shifted position of the character
                    int shiftedPosition = (char.ToUpper(c) - 'A' + shift) % 26;

                    // Convert the shifted position back into a character
                    char shiftedChar = (char)('A' + shiftedPosition);

                    // Add the encrypted character to the ciphertext
                    cipherText += shiftedChar;
                }
                else
                {
                    // Add non-alphabetic characters to the ciphertext as-is
                    cipherText += c;
                }
            }

            return cipherText;
        }

        public static string Decrypt(string cipherText, int shift)
        {
            string plainText = "";

            // Iterate through each character in the ciphertext
            foreach (char c in cipherText)
            {
                // Only decrypt alphabetical characters
                if (char.IsLetter(c))
                {
                    // Determine the unshifted position of the character
                    int unshiftedPosition = (char.ToUpper(c) - 'A' - shift + 26) % 26;

                    // Convert the unshifted position back into a character
                    char unshiftedChar = (char)('A' + unshiftedPosition);

                    // Add the decrypted character to the plaintext
                    plainText += unshiftedChar;
                }
                else
                {
                    // Add non-alphabetic characters to the plaintext as-is
                    plainText += c;
                }
            }

            return plainText;
        }


    }



}
