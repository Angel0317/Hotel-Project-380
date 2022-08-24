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
        public int room_num = 0;
      
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

            if (phonenum_txt.Text == "" || address_txt.Text == "" || zipcode_txt.Text == "" || state_txt.Text == "")
            {
                MessageBox.Show("Please fill information information.");
            }
            else if (totalguests.SelectedItem == null)
            {
                MessageBox.Show("Please pick number of guest.");
            }
            else
            {
                DateTime d1 = editcheckIn.Value;
                DateTime d2 = editCheckOut.Value;
                TimeSpan time = d2 - d1;
                double Days = time.TotalDays;
                int days = Convert.ToInt32(Days);
                string checkin = editcheckIn.Value.ToString();
                string checkout = editCheckOut.Value.ToString();

                Con.Open();
                String query = "UPDATE Cart_Table SET PhoneNumber = '" + phonenum_txt.Text + "', Address = '" + address_txt.Text + "', ZipCode = '" + zipcode_txt.Text + "', " +
                    "State = '" + state_txt.Text + "', CheckIn = '" + checkin + "', CheckOut = '" + checkout + "', Guests = '" + totalguests.Text + "', Nights = '" + days + "' WHERE RoomNumber = '" + room_num + "' ";
                SqlCommand save = new SqlCommand(query, Con);
                save.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Information Updated!");
                this.Close();
            }
          
        }

        private void Save_edit_Load(object sender, EventArgs e)
        {

        }

        private void firsttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
