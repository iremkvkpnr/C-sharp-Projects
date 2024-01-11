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
using System.IO;

namespace _152120201069_lab5
{   public partial class adminPanel : Form
    {
        public static string Id, userType, userName, nameSurname, password, mail;
        int a = 0;
        public static int Parametre_1=0;
        DataTable tablo = new DataTable();
        public adminPanel()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            userType = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            userName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            nameSurname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mail = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            password = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            XDocument xDoc = XDocument.Load(@"20201069.xml");

            XElement rootElement = xDoc.Root;
            int b = 1;
            foreach (XElement Personeller in rootElement.Elements())
            {
                if (Personeller.Element("ID").Value == (txtcontrol.Text))
                {
                    Personeller.Remove();
                    MessageBox.Show("kayıt silindi.");
                    b++;
                  
                }
            }
            if (txtcontrol.Text == "")
            {
                lblwarning.Text = "lütfen bir id giriniz!";
            }
            else if (b==1)
            {
                MessageBox.Show("kayit bulunamadı.");
            }
            xDoc.Save(@"20201069.xml");

        }

        private void adminPanel_Load(object sender, EventArgs e)
        {
           
           
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("UserType", typeof(string));
            tablo.Columns.Add("UserName", typeof(string));
            tablo.Columns.Add("NameSurname", typeof(string));
            tablo.Columns.Add("Mail", typeof(string));
            dataGridView1.DataSource = tablo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Parametre_1 = 0;
            Add_Update frm_add = new Add_Update();
            frm_add.Show();
            this.Visible = false;
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Parametre_1++;
            if (a == 0) { Listele(); }
            a++;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int index = dataGridView1.CurrentCell.ColumnIndex;
                Add_Update frm_add = new Add_Update();
                frm_add.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Lütfen satır seçiniz.");
            }
        }
        public  void Listele()
        {
          DataSet dset = new DataSet();
          XmlReader reader = XmlReader.Create(@"20201069.xml", new XmlReaderSettings());
           dset.ReadXml(reader);

            dataGridView1.DataSource = dset.Tables[0];
            reader.Close();
           
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            Listele();
        }

     
    }
}
