using System;
using System.Text;
using System.Security.Cryptography;

namespace VAICOM
{

    namespace Helpers
    {

        public static class Crypto
        {

            private const DataProtectionScope Scope = DataProtectionScope.CurrentUser;

            public static string Encrypt(this string text)
            {
                try
                {
                    if (text == null) { throw new ArgumentNullException("text"); }
                    var data = Encoding.Unicode.GetBytes(text);
                    byte[] encrypted = ProtectedData.Protect(data, null, Scope);
                    return Convert.ToBase64String(encrypted);
                }
                catch
                {
                    return null;
                }
            }

            public static string Decrypt(this string cipher)
            {
                try
                {
                    if (cipher == null) { throw new ArgumentNullException("cipher"); }
                    byte[] data = Convert.FromBase64String(cipher);
                    byte[] decrypted = ProtectedData.Unprotect(data, null, Scope);
                    return Encoding.Unicode.GetString(decrypted);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
