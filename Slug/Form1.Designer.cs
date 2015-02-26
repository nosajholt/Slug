namespace Slug
{
	partial class frmSlug
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSlug));
			this.btnDie = new System.Windows.Forms.Button();
			this.picBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDie
			// 
			this.btnDie.Location = new System.Drawing.Point(163, 167);
			this.btnDie.Name = "btnDie";
			this.btnDie.Size = new System.Drawing.Size(75, 23);
			this.btnDie.TabIndex = 0;
			this.btnDie.Text = "DIE";
			this.btnDie.UseVisualStyleBackColor = true;
			this.btnDie.Click += new System.EventHandler(this.btnDie_Click);
			// 
			// picBox
			// 
			this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
			this.picBox.Location = new System.Drawing.Point(25, 22);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(213, 129);
			this.picBox.TabIndex = 1;
			this.picBox.TabStop = false;
			// 
			// frmSlug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(278, 213);
			this.Controls.Add(this.picBox);
			this.Controls.Add(this.btnDie);
			this.Name = "frmSlug";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Slug";
			((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDie;
        private System.Windows.Forms.PictureBox picBox;
    }
}

