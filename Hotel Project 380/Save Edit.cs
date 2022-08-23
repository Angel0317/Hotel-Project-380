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
    public partial class Save_edit : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\angel\OneDrive\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30");
        public static Save_edit instance;
        public string first_name = "";
      
        public Save_edit()
        {
            InitializeComponent();
            instance = this;

        }
     
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
          
            //if (Nametxt.Text == "")
            //{
            //    MessageBox.Show("Please fill information information.");
            //}
            //else
            //{
            //    int num = 101;
            //    MessageBox.Show(first_name);

            //    Con.Open();
            //    //String query = "UPDATE Cart_Table SET FirstName = '" + firsttxt.Text + "', LastName = '" + lasttxt.Text + "', Address = '" + address_txt.Text + "', PhoneNumber = '" + numbertxt.Text + "', " +
            //    //    "ZipCode = '" + zipcode_txt.Text + "', State = '" + state_txt.Text + "' WHERE Email = '" + email.ToString() + "' ";
            //    SqlCommand save = new SqlCommand("UPDATE Cart_Table SET LastName = '"+Nametxt.Text+"' WHERE RoomNumber = '"+num+"'", Con);
            //    save.ExecuteNonQuery();
            //    Con.Close();
            //    MessageBox.Show("Information Updated!");
            //    this.Close();

            //}
        }

        private void Save_edit_Load(object sender, EventArgs e)
        {

        }

        private void firsttxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
