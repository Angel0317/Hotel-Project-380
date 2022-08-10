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
    public partial class New_Reservation : Form
    {
        public static New_Reservation instance;

        SqlCommand cmd= new SqlCommand();
        SqlConnection conn;
        SqlDataAdapter adapter;
        String RoomDet;
        
        public TextBox tb1;
        public New_Reservation()
        {
            InitializeComponent();
            instance = this;

        }

        private void New_Reservation_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void customTextBox1__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RoomDet = "Studio Deluxe Room \n 1 king Bed/ 2 Queen Beds\n Max Guests 4";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datein_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amari\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            cmd = new SqlCommand("INSERT INTO Reservation_Table (Firstname,lastname,emailadress,address,zip,state,datein,dateout,RoomDetails,days) VALUES (@Firstname,@lastname,@emailadress,@address,@zip,@state,@datein,@dateout,@RoomDetails,@days)", conn);

            cmd.Parameters.Add("@Firstname", textBox3.Text);
            cmd.Parameters.Add("@lastname", textBox1.Text);
            cmd.Parameters.Add("@emailadress", textBox2.Text);
            cmd.Parameters.Add("@address", textBox7.Text);
            cmd.Parameters.Add("@zip", textBox8.Text);
            cmd.Parameters.Add("@state", textBox9.Text);
            cmd.Parameters.Add("@datein", datein.Text);
            cmd.Parameters.Add("@dateout", dateout.Text);
            cmd.Parameters.Add("@RoomDetails", RoomDet);

            DateTime d1 = dateout.Value;
            DateTime d2 = datein.Value;
            TimeSpan time = d1 - d2;

            double Days = time.TotalDays;
            
            int days = Convert.ToInt32(Days);

           

            cmd.Parameters.Add("@days", days.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();

            Cart form = new Cart();
            form.Show();

            Cart.instance.lab1.Text = textBox3.Text;


        }

        private void radioBtnSuite_CheckedChanged(object sender, EventArgs e)
        {
            RoomDet = "One Bedroom Panoramic View Suite\n 1 King Bed/ 2 Queen Beds\n Max Guests 4";
        }

        private void radioBtnPentHouse_CheckedChanged(object sender, EventArgs e)
        {
            RoomDet = "Two Bedroom Penthouse Sky View  \n 2 King Beds\n Max Guests 4";
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            RoomDet = " Three Bedroom Presidential Suite  \n 3 King Beds\nMax Guests 6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart.instance.lab1.Text = textBox3.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
