using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using testScript;


namespace _152120201069_lab3
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        public testClass tst = new testClass();
        int score;
        public static StringBuilder encrypt(String text, int s)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    char ch = (char)(((int)text[i] + s - 65) % 26 + 65);
                    result.Append(ch);
                }
                else if (char.IsLower(text[i]))
                {
                    char ch = (char)(((int)text[i] + s - 97) % 26 + 97);
                    result.Append(ch);
                }
                else if (text[i] == ' ') // boşluk karakterini özel olarak işleme al
                {
                    result.Append(' ');
                }
                else // diğer özel karakterleri atla
                {
                    continue;
                }
            }
            return result;
        }
   
        public static string VigenereEncrypt(string plaintext, string keyword)
        {
            string ciphertext = "";
            plaintext = plaintext.ToUpper();
            keyword = keyword.ToUpper();
            int keywordIndex = 0;
            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    int shift = keyword[keywordIndex] - 'A';
                    char ch = (char)(((c - 'A' + shift) % 26) + 'A');
                    ciphertext += ch;
                    keywordIndex = (keywordIndex + 1) % keyword.Length;
                }
                else
                {
                    ciphertext += c;
                }
            }
            return ciphertext;
        }

        public static string VigenereDecrypt(string ciphertext, string keyword)
        {
            string plaintext = "";
            ciphertext = ciphertext.ToUpper();
            keyword = keyword.ToUpper();
            int keywordIndex = 0;
            foreach (char c in ciphertext)
            {
                if (char.IsLetter(c))
                {
                    int shift = keyword[keywordIndex] - 'A';
                    char ch = (char)(((c - 'A' - shift + 26) % 26) + 'A');
                    plaintext += ch;
                    keywordIndex = (keywordIndex + 1) % keyword.Length;
                }
                else
                {
                    plaintext += c;
                }
            }
            return plaintext;
        }

        private void txtogrno_TextChanged(object sender, EventArgs e)
        {
            int a = txtogrno.TextLength;
            if (a < 8)
            {
                lblWarning.Visible = true;
                lblWarning.Text = "Kullanıcı adı en az 8 karakterden oluşmalı!";
                lblWarning.BackColor = Color.Red;
            }
            else
            {
                lblWarning.Visible = false;
            }
        }

        private void lblWarning_Click(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }

        private void btnŞifrele_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            path = path + "\\"  + txtogrno.Text+ ".csv";
            if (rdcaesar.Checked == true && rdŞifreleme.Checked == true)
            {
                String cipher_text = encrypt(txtMetin.Text, 7).ToString();
                lblŞifreSonuç.Text = cipher_text;
             
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(lblŞifreSonuç.Text);
                }
                string a = encrypt(txtMetin.Text, 7).ToString();
                string b = VigenereEncrypt(txtMetin.Text, "esoguce");
                string c = encrypt(txtMetin.Text, 19).ToString();
                string d = VigenereDecrypt(txtMetin.Text, "esoguce");
                score = tst.testFuncApp3(txtogrno.Text, txtMetin.Text, "Caesar", "encrypt", lblŞifreSonuç.Text,a,b,c,d);

                lblSkor.Text = "Skor: " + score;
            }

            else if (rdcaesar.Checked == true && rdDeşifreleme.Checked == true)
            {
                String decipher_text = encrypt(txtMetin.Text, 19).ToString();
                lblŞifreSonuç.Text = decipher_text;
               
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(lblŞifreSonuç.Text);
                }
                string a = encrypt(txtMetin.Text, 7).ToString();
                string b = VigenereEncrypt(txtMetin.Text, "esoguce");
                string c = encrypt(txtMetin.Text, 19).ToString();
                string d = VigenereDecrypt(txtMetin.Text, "esoguce");
                score = tst.testFuncApp3(txtogrno.Text, txtMetin.Text, "Caesar", "decrypt", lblŞifreSonuç.Text,a,b,c,d);         
                lblSkor.Text = "Skor: " + score;
            }
            else if (rdvigener.Checked == true && rdŞifreleme.Checked == true)
            {

                String cipher_text2 = VigenereEncrypt(txtMetin.Text, "esoguce");
                lblŞifreSonuç.Text = cipher_text2;
               
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(lblŞifreSonuç.Text);
                }
                string a = encrypt(txtMetin.Text, 7).ToString();
                string b = VigenereEncrypt(txtMetin.Text, "esoguce");
                string c = encrypt(txtMetin.Text, 19).ToString();
                string d = VigenereDecrypt(txtMetin.Text, "esoguce");
                score = tst.testFuncApp3(txtogrno.Text, txtMetin.Text, "Vigenere", "encrypt", lblŞifreSonuç.Text,a,b,c,d);
                lblSkor.Text = "Skor: " + score;

            }
            else if (rdvigener.Checked == true && rdDeşifreleme.Checked == true)
            {
                String decipher_text2 = VigenereDecrypt(txtMetin.Text, "esoguce");
                lblŞifreSonuç.Text = decipher_text2;
               
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(lblŞifreSonuç.Text);
                }
                string a = encrypt(txtMetin.Text, 7).ToString();
                string b = VigenereEncrypt(txtMetin.Text, "esoguce");
                string c = encrypt(txtMetin.Text, 19).ToString();
                string d = VigenereDecrypt(txtMetin.Text, "esoguce");
                score = tst.testFuncApp3(txtogrno.Text, txtMetin.Text, "Vigenere", "decrypt", lblŞifreSonuç.Text,a,b,c,d );
                lblSkor.Text = "Skor: " + score;
            }

        }

       
    }
}
