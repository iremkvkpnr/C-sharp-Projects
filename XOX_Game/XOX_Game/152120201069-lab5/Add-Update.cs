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

namespace _152120201069_lab5
{
    public partial class Add_Update : Form
    {

        public Add_Update()
        {
            InitializeComponent();
        }

       
        private void btnBack_Click(object sender, EventArgs e)
        {
            adminPanel frm_adminPanel = new adminPanel();
            frm_adminPanel.Show();
            this.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            //Burada dosyayı oluşturup kapattım
            //XmlTextWriter dosya = new XmlTextWriter(@"20201069.xml", Encoding.UTF8);
            //dosya.Formatting = Formatting.Indented;
            //dosya.WriteStartDocument();
            //dosya.WriteStartElement("Users");
            //dosya.WriteEndElement();
            //dosya.Close();

            if (adminPanel.Parametre_1 == 0)
            {
                XDocument xdosya = XDocument.Load(@"20201069.xml");
                XElement rootelement = xdosya.Root;
                XElement element = new XElement("User");
                XElement ID = new XElement("ID", txtId.Text);
                XElement usertype = new XElement("UserType", txtUserType.Text);
                XElement username = new XElement("UserName", txtUserName.Text);
                XElement namesurname = new XElement("NameSurname", txtNameSurname.Text);
                XElement mail = new XElement("Mail", txtMail.Text);
                XElement password = new XElement("Password", txtPassword.Text);
                element.Add(ID, usertype, username, namesurname, mail, password);
                rootelement.Add(element);
                xdosya.Save(@"20201069.xml");
                MessageBox.Show("Kayit eklendi");
            }
            else
            {

                XDocument xdosya = XDocument.Load(@"20201069.xml");
                XElement element = xdosya.Element("Users").Elements("User").FirstOrDefault(x => x.Element("ID").Value == adminPanel.Id);

                if (element != null)
                {

                    element.SetElementValue("ID", txtId.Text);
                    element.SetElementValue("UserType", txtUserType.Text);
                    element.SetElementValue("UserName", txtUserName.Text);
                    element.SetElementValue("NameSurname", txtNameSurname.Text);
                    element.SetElementValue("Mail", txtMail.Text);
                    element.SetElementValue("Password", txtPassword.Text);
                    xdosya.Save(@"20201069.xml");
                    MessageBox.Show("Kayit güncellendi");

                }
            }
        }

        private void Add_Update_Load(object sender, EventArgs e)
        {
            txtId.Text = adminPanel.Id;
            txtUserType.Text = adminPanel.userType;
            txtUserName.Text = adminPanel.userName;
            txtNameSurname.Text = adminPanel.nameSurname;
            txtMail.Text = adminPanel.mail;
            txtPassword.Text = adminPanel.password;
        }
    }
}

