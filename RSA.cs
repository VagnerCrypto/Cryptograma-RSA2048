using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RSAEncryption
{
    class RSA
    {
        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    RSA.ImportParameters(RSAKeyInfo);


                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Não foi possível assinar a mensagem",
               
                    "Ocorreu um erro na encriptação; Motivo: " + ex.Message);

                return null;
            }
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    
                    rsa.ImportParameters(RSAKeyInfo);

                 
                    decryptedData = rsa.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Não foi possível assinar a mensagem; Motivo: " + ex.Message,
                                "Ocorreu um erro na decriptação;");

                return null;
            }
        }
    }
}