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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amari\Downloads\HotelDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {


        }/// <summary>
         /// Amarinder Singh
         /// 8/15/2022
         /// 
         /// this method brings up a different Form once sign in is clicked
         /// 
         /// set up a form design similar to the one that the vistor sees, but this one wes will code
         /// it to pull data from database onto the gridview tab.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Reservationtb_Click(object sender, EventArgs e)
        {


        }

        private void reservationCheckBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click_1(object sender, EventArgs e)
        {

            Form1 mainf = new Form1();
            mainf.Show();
            this.Close();
        }
    }
}
