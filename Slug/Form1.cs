using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Slug
{
    public partial class frmSlug : Form
    {
        public frmSlug()
        {
            InitializeComponent();
            picBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnDie_Click(object sender, EventArgs e)
        {
			btnDie.Text = "DIE";
			btnDie.Update();
			try
			{
				picBox.Image = Properties.Resources._02slug;
				picBox.Refresh();
				System.Threading.Thread.Sleep(400);
				picBox.Image = Properties.Resources._03slug;
				picBox.Refresh();
				System.Threading.Thread.Sleep(400);
				picBox.Image = Properties.Resources._04slug;
				picBox.Refresh();
				System.Threading.Thread.Sleep(400);
				picBox.Image = Properties.Resources._05slug;
				picBox.Refresh();
				System.Threading.Thread.Sleep(400);
				picBox.Image = Properties.Resources._06slug;
				picBox.Refresh();
				System.Threading.Thread.Sleep(400);
				picBox.Image = Properties.Resources._07slug;
				picBox.Refresh();
				picBox.SizeMode = PictureBoxSizeMode.Zoom;
				picBox.Refresh();

				btnDie.Text = "Try again";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
        }
    }
}