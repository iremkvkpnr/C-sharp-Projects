using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

using System.IO;
namespace _152120201069_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // this.IsMdiContainer = true;
            txtPassword.PasswordChar = '*';
            LoadRememberMeCredentials();

        }        
        private void btnLogİn_Click(object sender, EventArgs e)
        {
            //XmlTextWriter dosya = new XmlTextWriter(@"20201069.xml", Encoding.UTF8);
            //dosya.Formatting = Formatting.Indented;
            //dosya.WriteStartDocument();
            //dosya.WriteStartElement("Users");
            //dosya.WriteEndElement();
            //dosya.Close();

            XDocument xdoc = XDocument.Load(@"20201069.xml");
            string xpathExpression = "/Users/User/UserType";

            // XPath ifadesini kullanarak "UserType" öğesini seçin
            XElement userTypeElement = xdoc.XPathSelectElement(xpathExpression);
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            XElement userElement = xdoc.XPathSelectElement($"/Users/User[UserName='{username}']");
            if (txtUserName.Text == "user" && txtPassword.Text == "user")
            {
                UserForm frm_user = new UserForm();
                //frm_user.MdiParent = this;
                frm_user.Show();
                this.Visible = false;
            }
            else if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                AdminForm frm_admin = new AdminForm();
                //frm_admin.MdiParent = this;
                frm_admin.Show();
                this.Visible = false;
            }

            else if (userElement != null)
            {
                string storedPassword = userElement.Element("Password")?.Value;

                if (password == storedPassword)
                {
                    // Giriş başarılı
                    if (userTypeElement != null)
                    {
                        string userType = userTypeElement.Value;

                        if (userType == "admin")
                        {
                            AdminForm frm_admin = new AdminForm();
                            //frm_admin.MdiParent = this;
                            frm_admin.Show();
                            this.Visible = false;
                        }
                        if (userType == "user")
                        {
                            UserForm frm_user = new UserForm();
                            //frm_user.MdiParent = this;
                            frm_user.Show();
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        // "UserType" öğesi bulunamazsa yapılacak işlemler
                        MessageBox.Show("Hata: 'UserType' öğesi bulunamadı.");
                    }

                }
                else
                {
                    // Hatalı şifre
                    MessageBox.Show("Hatalı şifre. Lütfen tekrar deneyin.");
                }
            }
            else
            {
                // Kullanıcı adı bulunamadı
                MessageBox.Show("Kullanıcı adı bulunamadı. Lütfen kayıtlı bir kullanıcı adı girin.");
            }

        }

        private void rdshowPass_CheckedChanged(object sender, EventArgs e)
        {
            {
                //checkBox işaretli ise
                if (rdshowPass.Checked)
                {
                    //karakteri göster.
                    txtPassword.PasswordChar = '\0';
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    txtPassword.PasswordChar = '*';
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Parametre_1 = 0;
            Add_Update frm_add = new Add_Update();
            frm_add.Show();
            this.Visible = false;
        }
        private void SaveRememberMeCredentials(string username, string password)
        {
           
            XmlTextWriter dosya = new XmlTextWriter(@"hatirla.xml", Encoding.UTF8);
            dosya.Formatting = Formatting.Indented;
            dosya.WriteStartDocument();
            dosya.WriteStartElement("Users");
            dosya.WriteEndElement();
            dosya.Close();
            XDocument xdosya = XDocument.Load(@"hatirla.xml");
            XElement rootelement = xdosya.Root;
            XElement element = new XElement("User");
            XElement userName = new XElement("UserName", txtUserName.Text);
            XElement Password = new XElement("Password", txtPassword.Text);
            element.Add(userName,Password);
            rootelement.Add(element);
            xdosya.Save(@"hatirla.xml");
        }
        private void chkbenihatırla_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkbenihatırla.Checked)
            {
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                SaveRememberMeCredentials(username, password);
            }
        }
        private void LoadRememberMeCredentials()
        {
            if (File.Exists("hatirla.xml"))
            {
                XDocument xdoc = XDocument.Load("hatirla.xml");

                string username = xdoc.Root?.Element("User")?.Element("UserName")?.Value;
                string password = xdoc.Root?.Element("User")?.Element("Password")?.Value;

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    txtUserName.Text = username;
                    txtPassword.Text = password;
                }
            }
        }

    }
}
