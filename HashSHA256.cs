using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RSAEncryption
{
    class HashSHA256
    {
        public static string SHA256Hashing(string data)
        {
            var build = new StringBuilder();

            try
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] cry = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));

                    for (int i = 0; i < cry.Length; i++)
                        build.Append(cry[i].ToString("X2"));

                }
            }
            catch(CryptographicException ex)
            {
                MessageBox.Show("Ocorreu um erro ao se calcular o Hash. \nMotivo: " + ex.Message,
                                "ERRO DE HASH", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            return build.ToString();
        }
    }
}
