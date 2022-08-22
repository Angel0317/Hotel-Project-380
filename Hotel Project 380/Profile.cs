using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hotel_Project_380
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }



        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Amarinder Singh 8/14/16
        /// This to confirm is admin username and password is matchedm if it doesnt match, this error message comes up
        /// once valid input is put in then, it hides this form and opnes up the Staff page.
        /// also disgned this whole Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      


        private void Staff_ID_TextChanged(object sender, EventArgs e)
        {


        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (Staff_ID.Text == "admin" && Staff_Password.Text == "admin")
            {
                new Staff().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong password or username");
                Staff_ID.Clear();
                Staff_Password.Clear();
                Staff_ID.Focus();
            }
        }
    }
}
