using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Project_380
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.panelDesktop.Controls.Count > 0)
                this.panelDesktop.Controls.RemoveAt(0);
            Form f = Form as Form;

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(f);
            this.panelDesktop.Tag = f;
            f.BringToFront();
            f.Show();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            loadform(new New_Reservation());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            loadform(new New_Reservation());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            loadform(new About());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            loadform(new Edit());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            loadform(new Profile());
        }
    }
}
