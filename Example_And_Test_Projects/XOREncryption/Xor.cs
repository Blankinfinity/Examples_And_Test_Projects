using System;

namespace XOREncryption
{
    public static class Xor
    {
        public static string EncryptDecrypt(string text, int key)
        {
            var newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                var charValue = Convert.ToInt32(text[i]); //get the ASCII value of the character
                charValue ^= key; //xor the value

                newText += char.ConvertFromUtf32(charValue); //convert back to string
            }

            return newText;
        }
    }
}
