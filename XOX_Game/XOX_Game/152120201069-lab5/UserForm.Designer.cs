
namespace _152120201069_lab5
{
    partial class UserForm
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
            this.btnDif = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDif
            // 
            this.btnDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDif.Location = new System.Drawing.Point(36, 114);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(238, 73);
            this.btnDif.TabIndex = 0;
            this.btnDif.Text = "Difficulty";
            this.btnDif.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(503, 114);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(238, 73);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnDif);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDif;
        private System.Windows.Forms.Button btnNewGame;
    }
}