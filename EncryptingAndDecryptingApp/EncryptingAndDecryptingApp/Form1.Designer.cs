
namespace _152120201069_lab3
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
            this.lblogrencino = new System.Windows.Forms.Label();
            this.txtogrno = new System.Windows.Forms.TextBox();
            this.lblMetin = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.grpAlgoritma = new System.Windows.Forms.GroupBox();
            this.rdvigener = new System.Windows.Forms.RadioButton();
            this.rdcaesar = new System.Windows.Forms.RadioButton();
            this.grpŞifreleme = new System.Windows.Forms.GroupBox();
            this.rdDeşifreleme = new System.Windows.Forms.RadioButton();
            this.rdŞifreleme = new System.Windows.Forms.RadioButton();
            this.btnŞifrele = new System.Windows.Forms.Button();
            this.lblŞifreSonuç = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.grpAlgoritma.SuspendLayout();
            this.grpŞifreleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblogrencino
            // 
            this.lblogrencino.AutoSize = true;
            this.lblogrencino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogrencino.Location = new System.Drawing.Point(28, 34);
            this.lblogrencino.Name = "lblogrencino";
            this.lblogrencino.Size = new System.Drawing.Size(150, 20);
            this.lblogrencino.TabIndex = 0;
            this.lblogrencino.Text = "Öğrenci Numarası:";
            // 
            // txtogrno
            // 
            this.txtogrno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtogrno.Location = new System.Drawing.Point(184, 31);
            this.txtogrno.Name = "txtogrno";
            this.txtogrno.Size = new System.Drawing.Size(100, 27);
            this.txtogrno.TabIndex = 1;
            this.txtogrno.Text = "20201069";
            this.txtogrno.TextChanged += new System.EventHandler(this.txtogrno_TextChanged);
            // 
            // lblMetin
            // 
            this.lblMetin.AutoSize = true;
            this.lblMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetin.Location = new System.Drawing.Point(28, 71);
            this.lblMetin.Name = "lblMetin";
            this.lblMetin.Size = new System.Drawing.Size(285, 20);
            this.lblMetin.TabIndex = 2;
            this.lblMetin.Text = "Şifrelenecek/Şifresi çözülecek metin:";
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetin.Location = new System.Drawing.Point(31, 107);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(487, 27);
            this.txtMetin.TabIndex = 3;
            this.txtMetin.Text = "MERHABA DUNYALI NASILSIN";
            // 
            // grpAlgoritma
            // 
            this.grpAlgoritma.Controls.Add(this.rdvigener);
            this.grpAlgoritma.Controls.Add(this.rdcaesar);
            this.grpAlgoritma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAlgoritma.Location = new System.Drawing.Point(21, 177);
            this.grpAlgoritma.Name = "grpAlgoritma";
            this.grpAlgoritma.Size = new System.Drawing.Size(221, 129);
            this.grpAlgoritma.TabIndex = 4;
            this.grpAlgoritma.TabStop = false;
            this.grpAlgoritma.Text = "Algoritmalar";
            // 
            // rdvigener
            // 
            this.rdvigener.AutoSize = true;
            this.rdvigener.Location = new System.Drawing.Point(11, 70);
            this.rdvigener.Name = "rdvigener";
            this.rdvigener.Size = new System.Drawing.Size(150, 24);
            this.rdvigener.TabIndex = 1;
            this.rdvigener.TabStop = true;
            this.rdvigener.Text = "Vigenère Cipher";
            this.rdvigener.UseVisualStyleBackColor = true;
            // 
            // rdcaesar
            // 
            this.rdcaesar.AutoSize = true;
            this.rdcaesar.Location = new System.Drawing.Point(11, 27);
            this.rdcaesar.Name = "rdcaesar";
            this.rdcaesar.Size = new System.Drawing.Size(138, 24);
            this.rdcaesar.TabIndex = 0;
            this.rdcaesar.TabStop = true;
            this.rdcaesar.Text = "Caesar Cipher";
            this.rdcaesar.UseVisualStyleBackColor = true;
            // 
            // grpŞifreleme
            // 
            this.grpŞifreleme.Controls.Add(this.rdDeşifreleme);
            this.grpŞifreleme.Controls.Add(this.rdŞifreleme);
            this.grpŞifreleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpŞifreleme.Location = new System.Drawing.Point(337, 177);
            this.grpŞifreleme.Name = "grpŞifreleme";
            this.grpŞifreleme.Size = new System.Drawing.Size(218, 129);
            this.grpŞifreleme.TabIndex = 5;
            this.grpŞifreleme.TabStop = false;
            this.grpŞifreleme.Text = "Şifreleme/Deşifreleme";
            // 
            // rdDeşifreleme
            // 
            this.rdDeşifreleme.AutoSize = true;
            this.rdDeşifreleme.Location = new System.Drawing.Point(25, 72);
            this.rdDeşifreleme.Name = "rdDeşifreleme";
            this.rdDeşifreleme.Size = new System.Drawing.Size(121, 24);
            this.rdDeşifreleme.TabIndex = 1;
            this.rdDeşifreleme.TabStop = true;
            this.rdDeşifreleme.Text = "Deşifreleme";
            this.rdDeşifreleme.UseVisualStyleBackColor = true;
            // 
            // rdŞifreleme
            // 
            this.rdŞifreleme.AutoSize = true;
            this.rdŞifreleme.Location = new System.Drawing.Point(25, 29);
            this.rdŞifreleme.Name = "rdŞifreleme";
            this.rdŞifreleme.Size = new System.Drawing.Size(101, 24);
            this.rdŞifreleme.TabIndex = 0;
            this.rdŞifreleme.TabStop = true;
            this.rdŞifreleme.Text = "Şifreleme";
            this.rdŞifreleme.UseVisualStyleBackColor = true;
            // 
            // btnŞifrele
            // 
            this.btnŞifrele.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnŞifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnŞifrele.Location = new System.Drawing.Point(597, 294);
            this.btnŞifrele.Name = "btnŞifrele";
            this.btnŞifrele.Size = new System.Drawing.Size(160, 60);
            this.btnŞifrele.TabIndex = 6;
            this.btnŞifrele.Text = "Şifrele/Deşifrele";
            this.btnŞifrele.UseVisualStyleBackColor = false;
            this.btnŞifrele.Click += new System.EventHandler(this.btnŞifrele_Click);
            // 
            // lblŞifreSonuç
            // 
            this.lblŞifreSonuç.AutoSize = true;
            this.lblŞifreSonuç.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblŞifreSonuç.Location = new System.Drawing.Point(28, 390);
            this.lblŞifreSonuç.Name = "lblŞifreSonuç";
            this.lblŞifreSonuç.Size = new System.Drawing.Size(0, 20);
            this.lblŞifreSonuç.TabIndex = 7;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkor.Location = new System.Drawing.Point(594, 31);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(48, 20);
            this.lblSkor.TabIndex = 8;
            this.lblSkor.Text = "Skor:";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(309, 34);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 17);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Click += new System.EventHandler(this.lblWarning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblŞifreSonuç);
            this.Controls.Add(this.btnŞifrele);
            this.Controls.Add(this.grpŞifreleme);
            this.Controls.Add(this.grpAlgoritma);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.lblMetin);
            this.Controls.Add(this.txtogrno);
            this.Controls.Add(this.lblogrencino);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAlgoritma.ResumeLayout(false);
            this.grpAlgoritma.PerformLayout();
            this.grpŞifreleme.ResumeLayout(false);
            this.grpŞifreleme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblogrencino;
        private System.Windows.Forms.TextBox txtogrno;
        private System.Windows.Forms.Label lblMetin;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.GroupBox grpAlgoritma;
        private System.Windows.Forms.GroupBox grpŞifreleme;
        private System.Windows.Forms.Button btnŞifrele;
        private System.Windows.Forms.Label lblŞifreSonuç;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.RadioButton rdvigener;
        private System.Windows.Forms.RadioButton rdcaesar;
        private System.Windows.Forms.RadioButton rdDeşifreleme;
        private System.Windows.Forms.RadioButton rdŞifreleme;
    }
}

