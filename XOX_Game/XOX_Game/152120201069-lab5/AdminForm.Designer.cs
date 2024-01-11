
namespace _152120201069_lab5
{
    partial class AdminForm
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
            this.btndif = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndif
            // 
            this.btndif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndif.Location = new System.Drawing.Point(59, 144);
            this.btndif.Name = "btndif";
            this.btndif.Size = new System.Drawing.Size(190, 73);
            this.btndif.TabIndex = 0;
            this.btndif.Text = "Difficulty Level";
            this.btndif.UseVisualStyleBackColor = true;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel.Location = new System.Drawing.Point(294, 144);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(190, 73);
            this.btnAdminPanel.TabIndex = 1;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(547, 144);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(190, 73);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.btndif);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndif;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnNewGame;
    }
}