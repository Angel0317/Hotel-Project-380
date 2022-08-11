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

    public partial class Cart : Form
    {
        SqlConnection cart = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\angel\OneDrive\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30");
        public static Cart instance;
        public Label lab1;
        public Label lab2;
        public Label lab3;
        public Label lab4;
        public Label lab5;
        public PictureBox pic;

        public Cart()
        {
            InitializeComponent();
            instance = this;
            lab1 = room;
            lab2 = Details;
            lab3 = startdate;
            lab4 = leavedate;
            lab5 = Total;
            pic = pictureBox1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void roomType_Click(object sender, EventArgs e)
        {

        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            if (firstName.Text == "" || lastName.Text == "" || addresstxt.Text == "" || phonetxt.Text == "" || emailtxt.Text == "" || zipcodetxt.Text == "" || statetxt.Text == "")
            {
                MessageBox.Show("Please fill information text.");
            }
            else if (cardtxt.Text == "" || cvvtxt.Text == "" || billingtxt.Text == "" || expirationtxt.Text == "")
            {
                MessageBox.Show("Please enter payment information.");
            }
            else
            {
                cart.Open();
                SqlCommand cmd = new SqlCommand("insert into Cart_Table values ('" + firstName.Text + "','" + lastName.Text + "', '" + addresstxt.Text + "', '" + phonetxt.Text + "', '" + emailtxt.Text + "','" +
                    zipcodetxt.Text + "', '" + statetxt.Text + "')", cart);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation Confirmed! :D");
                cart.Close();
                this.Close();
            }

        
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void cvvtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void checkIn_Click(object sender, EventArgs e)
        {

        }
    }
}
