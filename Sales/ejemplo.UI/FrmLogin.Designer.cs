
namespace ejemplo.UI
{
    partial class FrmLogin
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
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassWord = new System.Windows.Forms.TextBox();
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(84, 63);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(219, 23);
            this.TxtUser.TabIndex = 0;
            // 
            // TxtPassWord
            // 
            this.TxtPassWord.Location = new System.Drawing.Point(84, 103);
            this.TxtPassWord.Name = "TxtPassWord";
            this.TxtPassWord.Size = new System.Drawing.Size(219, 23);
            this.TxtPassWord.TabIndex = 1;
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.Location = new System.Drawing.Point(161, 162);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(75, 23);
            this.BtnIngreso.TabIndex = 2;
            this.BtnIngreso.Text = "Ingreso";
            this.BtnIngreso.UseVisualStyleBackColor = true;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 254);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.TxtPassWord);
            this.Controls.Add(this.TxtUser);
            this.Name = "FrmLogin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassWord;
        private System.Windows.Forms.Button BtnIngreso;
    }
}