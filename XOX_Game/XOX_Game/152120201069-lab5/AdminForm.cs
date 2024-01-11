using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120201069_lab5
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame frm_game = new NewGame();
            //frm_user.MdiParent = this;
            frm_game.Show();
            this.Visible = false;
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            adminPanel frm_adminPanel = new adminPanel();
            //frm_user.MdiParent = this;
            frm_adminPanel.Show();
            this.Visible = false;
        }
    }
}
