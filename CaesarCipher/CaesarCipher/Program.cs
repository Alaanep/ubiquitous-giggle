

//Rewrite the loop as a method Encrypt() which takes a character array and key and returns an encrypted character array .
//Write a Decrypt() method which takes a character array and key and returns a decrypted character array.


using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int key = 3;

            Console.WriteLine("Enter your secret message: ");
            string input = Console.ReadLine().ToLower();
            char[] secretMessage = input.ToCharArray();

            string encrypted = Encrypt(secretMessage, key, alphabet);

            Console.WriteLine(encrypted);

            string decrypted = Decrypt(encrypted, key, alphabet);
            Console.WriteLine(decrypted);

        }

        static string Encrypt(char[] charArrToEncrypt, int key, char[]alphabet)
        {
            char[] encryptedMessage = new char[charArrToEncrypt.Length];
            //Console.WriteLine(encryptedMessage.Length);

            for (int i = 0; i < charArrToEncrypt.Length; i++)
            { 
                char letter = charArrToEncrypt[i];
                int idx = Array.IndexOf(alphabet, letter);
                if (idx == -1)
                {
                    encryptedMessage[i] = (char)32;
                }
                else
                {
                    int shiftedIdx = (idx + key) % 26;
                    encryptedMessage[i] = alphabet[shiftedIdx];
                }

            }
            return String.Join("", encryptedMessage);

            
        }

        static string Decrypt(string stringToDecrypt, int key, char[] alphabet)
        {
            char[] charToDecrypt = stringToDecrypt.ToCharArray();
            char[] decryptedMessage = new char[charToDecrypt.Length];

            for(int i = 0; i < charToDecrypt.Length; i++)
            {
                char letter = charToDecrypt[i];
                int idx = Array.IndexOf(alphabet, letter);
                if (idx == -1)
                {
                    decryptedMessage[i] = (char)32;
                }
                else
                {
                    int shiftedIdx = (idx - key) % 26;
                    decryptedMessage[i] = alphabet[shiftedIdx];
                }

            }

            return String.Join("", decryptedMessage);
        }
    }
}
