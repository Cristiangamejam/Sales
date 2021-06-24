
namespace ejemplo.Winform
{
    partial class FrmFootballTeam
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvFootball = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFootball)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFootball
            // 
            this.DgvFootball.AllowUserToAddRows = false;
            this.DgvFootball.AllowUserToDeleteRows = false;
            this.DgvFootball.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvFootball.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFootball.Location = new System.Drawing.Point(12, 12);
            this.DgvFootball.Name = "DgvFootball";
            this.DgvFootball.ReadOnly = true;
            this.DgvFootball.RowTemplate.Height = 25;
            this.DgvFootball.Size = new System.Drawing.Size(776, 150);
            this.DgvFootball.TabIndex = 0;
            // 
            // FrmFootballTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvFootball);
            this.Name = "FrmFootballTeam";
            this.Text = "Football Team";
            this.Load += new System.EventHandler(this.FrmFootballTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFootball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvFootball;
    }
}

