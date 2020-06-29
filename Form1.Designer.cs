namespace RSAEncryption
{
    partial class AssimetricCipher
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssimetricCipher));
            this.Encryption = new System.Windows.Forms.Button();
            this.PlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Decrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CipherText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HashText = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Caracteres = new System.Windows.Forms.Label();
            this.CaracteresDecry = new System.Windows.Forms.Label();
            this.CaracteresHexa = new System.Windows.Forms.Label();
            this.CaracteresSHA = new System.Windows.Forms.Label();
            this.CaracteresSHAHexa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Encryption
            // 
            this.Encryption.BackColor = System.Drawing.Color.SteelBlue;
            this.Encryption.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encryption.Location = new System.Drawing.Point(122, 274);
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(221, 76);
            this.Encryption.TabIndex = 0;
            this.Encryption.Text = "Criptografar";
            this.Encryption.UseVisualStyleBackColor = false;
            this.Encryption.Click += new System.EventHandler(this.Encryption_Click);
            // 
            // PlainText
            // 
            this.PlainText.Location = new System.Drawing.Point(122, 154);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(221, 70);
            this.PlainText.TabIndex = 1;
            this.PlainText.TextChanged += new System.EventHandler(this.PlainText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(296, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criptografia Assimétrica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rivest-Shamir-Adleman - RSA";
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.LightSalmon;
            this.Decrypt.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.Location = new System.Drawing.Point(475, 274);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(215, 76);
            this.Decrypt.TabIndex = 4;
            this.Decrypt.Text = "Descriptografar";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto claro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Texto cifrado";
            // 
            // CipherText
            // 
            this.CipherText.Location = new System.Drawing.Point(475, 154);
            this.CipherText.Name = "CipherText";
            this.CipherText.ReadOnly = true;
            this.CipherText.Size = new System.Drawing.Size(215, 70);
            this.CipherText.TabIndex = 7;
            this.CipherText.Text = "";
            this.CipherText.TextChanged += new System.EventHandler(this.CipherText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "HASH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "SHA-256";
            // 
            // HashText
            // 
            this.HashText.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashText.Location = new System.Drawing.Point(107, 385);
            this.HashText.Name = "HashText";
            this.HashText.Size = new System.Drawing.Size(644, 25);
            this.HashText.TabIndex = 10;
            this.HashText.TextChanged += new System.EventHandler(this.HashText_TextChanged);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(349, 154);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(120, 70);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Limpar";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Caracteres
            // 
            this.Caracteres.AutoSize = true;
            this.Caracteres.Location = new System.Drawing.Point(119, 237);
            this.Caracteres.Name = "Caracteres";
            this.Caracteres.Size = new System.Drawing.Size(70, 13);
            this.Caracteres.TabIndex = 12;
            this.Caracteres.Text = "Caracteres: 0";
            // 
            // CaracteresDecry
            // 
            this.CaracteresDecry.AutoSize = true;
            this.CaracteresDecry.Location = new System.Drawing.Point(472, 237);
            this.CaracteresDecry.Name = "CaracteresDecry";
            this.CaracteresDecry.Size = new System.Drawing.Size(70, 13);
            this.CaracteresDecry.TabIndex = 13;
            this.CaracteresDecry.Text = "Caracteres: 0";
            // 
            // CaracteresHexa
            // 
            this.CaracteresHexa.AutoSize = true;
            this.CaracteresHexa.Location = new System.Drawing.Point(638, 237);
            this.CaracteresHexa.Name = "CaracteresHexa";
            this.CaracteresHexa.Size = new System.Drawing.Size(44, 13);
            this.CaracteresHexa.TabIndex = 14;
            this.CaracteresHexa.Text = "Hexa: 0";
            // 
            // CaracteresSHA
            // 
            this.CaracteresSHA.AutoSize = true;
            this.CaracteresSHA.Location = new System.Drawing.Point(107, 414);
            this.CaracteresSHA.Name = "CaracteresSHA";
            this.CaracteresSHA.Size = new System.Drawing.Size(70, 13);
            this.CaracteresSHA.TabIndex = 15;
            this.CaracteresSHA.Text = "Caracteres: 0";
            // 
            // CaracteresSHAHexa
            // 
            this.CaracteresSHAHexa.AutoSize = true;
            this.CaracteresSHAHexa.Location = new System.Drawing.Point(107, 437);
            this.CaracteresSHAHexa.Name = "CaracteresSHAHexa";
            this.CaracteresSHAHexa.Size = new System.Drawing.Size(44, 13);
            this.CaracteresSHAHexa.TabIndex = 16;
            this.CaracteresSHAHexa.Text = "Hexa: 0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(322, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 70);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssimetricCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CaracteresSHAHexa);
            this.Controls.Add(this.CaracteresSHA);
            this.Controls.Add(this.CaracteresHexa);
            this.Controls.Add(this.CaracteresDecry);
            this.Controls.Add(this.Caracteres);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.HashText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainText);
            this.Controls.Add(this.Encryption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssimetricCipher";
            this.Text = "RSA Lab";
            this.Load += new System.EventHandler(this.AssimetricCipher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encryption;
        private System.Windows.Forms.TextBox PlainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox CipherText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HashText;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Caracteres;
        private System.Windows.Forms.Label CaracteresDecry;
        private System.Windows.Forms.Label CaracteresHexa;
        private System.Windows.Forms.Label CaracteresSHA;
        private System.Windows.Forms.Label CaracteresSHAHexa;
        private System.Windows.Forms.Button button1;
    }
}

