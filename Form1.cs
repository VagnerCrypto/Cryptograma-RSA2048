using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace RSAEncryption
{
    public partial class AssimetricCipher : Form
    {
        private static byte[] enc;
        public AssimetricCipher()
        {
            InitializeComponent();
        }

        private void AssimetricCipher_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Decrypt.Enabled = false;

            this.HashText.Enabled = false;

        }

        private void Encryption_Click(object sender, EventArgs e)
        {
            this.CipherText.Clear();
            this.HashText.Clear();
            this.Encryption.Enabled = false;


            if (!String.IsNullOrEmpty(PlainText.Text) && !String.IsNullOrWhiteSpace(PlainText.Text))
            {
                this.Decrypt.Enabled = true;

                UnicodeEncoding code = new UnicodeEncoding();
                byte[] datas = code.GetBytes(PlainText.Text);

                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
                {


                    byte[] encry = RSA.RSAEncrypt(datas, rsa.ExportParameters(false), false);


                    for (int i = 0; i < encry.Length; i++)
                        CipherText.Text += encry[i].ToString("X2");

                    CipherText.Text += rsa.KeySize.ToString();
                    enc = RSA.RSADecrypt(encry, rsa.ExportParameters(true), false);




                    string sha = HashSHA256.SHA256Hashing(PlainText.Text);


                    HashText.Text += sha;
                }

            }
            else
            {
                MessageBox.Show("Caixa de texto vazia", "Digite algo para criptografar!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Encryption.Enabled = true;
                this.Decrypt.Enabled = false;

                PlainText.Focus();
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            CipherText.Clear();

            this.Decrypt.Enabled = false;
            this.Encryption.Enabled = true;

            UnicodeEncoding code = new UnicodeEncoding();

            CipherText.Text += code.GetString(enc);
        }


        private void PlainText_TextChanged(object sender, EventArgs e)
        {
            int len = PlainText.TextLength;

            Caracteres.Text = "Caracteres: " +len.ToString();
        }

        private void CipherText_TextChanged(object sender, EventArgs e)
        {
            int len = CipherText.TextLength;

            CaracteresDecry.Text = "Caracteres: " + len.ToString();

            int len2 = CipherText.TextLength/2;

            if(Decrypt.Enabled)
                CaracteresHexa.Text = "Hexa: " + len2.ToString();
        }

        private void HashText_TextChanged(object sender, EventArgs e)
        {
            int len = HashText.TextLength;

            CaracteresSHA.Text = "Caracteres: " + len.ToString();

            int len2 = HashText.TextLength / 2;

            
            CaracteresSHAHexa.Text = "Hexa: " + len2.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            HashText.Clear();
            PlainText.Clear();
            CipherText.Clear();

            PlainText.Focus();

            this.Encryption.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
