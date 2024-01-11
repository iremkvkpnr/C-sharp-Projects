
namespace _152120201069_lab5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblusername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogİn = new System.Windows.Forms.Button();
            this.rdshowPass = new System.Windows.Forms.RadioButton();
            this.chkbenihatırla = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(236, 25);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(121, 25);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = " User Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(236, 114);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(240, 62);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(251, 30);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(241, 142);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(251, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogİn
            // 
            this.btnLogİn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogİn.Location = new System.Drawing.Point(276, 358);
            this.btnLogİn.Name = "btnLogİn";
            this.btnLogİn.Size = new System.Drawing.Size(165, 55);
            this.btnLogİn.TabIndex = 4;
            this.btnLogİn.Text = "Log In";
            this.btnLogİn.UseVisualStyleBackColor = true;
            this.btnLogİn.Click += new System.EventHandler(this.btnLogİn_Click);
            // 
            // rdshowPass
            // 
            this.rdshowPass.AutoSize = true;
            this.rdshowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdshowPass.Location = new System.Drawing.Point(241, 196);
            this.rdshowPass.Name = "rdshowPass";
            this.rdshowPass.Size = new System.Drawing.Size(174, 29);
            this.rdshowPass.TabIndex = 5;
            this.rdshowPass.TabStop = true;
            this.rdshowPass.Text = "Show Password";
            this.rdshowPass.UseVisualStyleBackColor = true;
            this.rdshowPass.CheckedChanged += new System.EventHandler(this.rdshowPass_CheckedChanged);
            // 
            // chkbenihatırla
            // 
            this.chkbenihatırla.AutoSize = true;
            this.chkbenihatırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbenihatırla.Location = new System.Drawing.Point(240, 234);
            this.chkbenihatırla.Name = "chkbenihatırla";
            this.chkbenihatırla.Size = new System.Drawing.Size(133, 29);
            this.chkbenihatırla.TabIndex = 6;
            this.chkbenihatırla.Text = "Beni Hatırla";
            this.chkbenihatırla.UseVisualStyleBackColor = true;
            this.chkbenihatırla.CheckedChanged += new System.EventHandler(this.chkbenihatırla_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(241, 278);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 44);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkbenihatırla);
            this.Controls.Add(this.rdshowPass);
            this.Controls.Add(this.btnLogİn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblusername);
            this.Name = "Form1";
            this.Text = "Form1";
        //    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogİn;
        private System.Windows.Forms.RadioButton rdshowPass;
        private System.Windows.Forms.CheckBox chkbenihatırla;
        private System.Windows.Forms.Button btnRegister;
    }
}

