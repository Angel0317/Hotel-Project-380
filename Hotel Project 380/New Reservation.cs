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
        Image studio;
        Image suite;
        Image pent;
        Image Pres;
        
        public New_Reservation()
        {
            InitializeComponent();

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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datein_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
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

            //Cart.instance.lab1.Text = textBox3.Text;
            */

        }

        private void radioBtnSuite_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioBtnPentHouse_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void radioBtnStudio_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Cart form = new Cart();
           // int max = int.Parse(guestnum.SelectedItem.ToString());

            if (guestnum.SelectedItem == null)
            {
                MessageBox.Show("Please choose the number of guests.");
            }
           else if (!radioBtnStudio.Checked && !radioBtnSuite.Checked && !radioBtnPentHouse.Checked && !radiobtnPres.Checked)
           {
                MessageBox.Show("Please choose a room.");
           }

            if (radioBtnStudio.Checked && guestnum.SelectedItem != null)
            {
               // studio = Image.FromFile(@"C:\Users\angel\source\repos\Hotel-Project-380\Hotel Project 380\pics\studio5.jpg");
                Cart.instance.lab1.Text = "Studio Deluxe Stay";
                Cart.instance.lab2.Text = "One King or Two Queen";
                Cart.instance.lab3.Text = dateTimePicker1.Value.ToString();
                Cart.instance.lab4.Text = dateTimePicker2.Value.ToString();
                Cart.instance.lab5.Text = guestnum.SelectedItem.ToString();
                Cart.instance.pic.Image = studio;
                form.Show();
               
            }
            else if(radioBtnSuite.Checked && guestnum.SelectedItem != null)
            {
                suite = Image.FromFile(@"C:\Users\angel\source\repos\Hotel-Project-380\Hotel Project 380\pics\suitepic2.jpg");
                Cart.instance.lab1.Text = "Panoramic Suite Stay";
                Cart.instance.lab2.Text = "One Bedroom\nOne King or Two Queen";
                Cart.instance.lab3.Text = dateTimePicker1.Value.ToString();
                Cart.instance.lab4.Text = dateTimePicker2.Value.ToString();
                Cart.instance.lab5.Text = guestnum.SelectedItem.ToString();
                Cart.instance.pic.Image = suite;
                form.Show();
                
               
            }
            else if(radioBtnPentHouse.Checked && guestnum.SelectedItem != null)
            {
                pent = Image.FromFile(@"C:\Users\angel\source\repos\Hotel-Project-380\Hotel Project 380\pics\pent.jpg");
                Cart.instance.lab1.Text = "Penthouse Sky View Stay";
                Cart.instance.lab2.Text = "Two King Beds\nTwo Master Bedrooms";
                Cart.instance.lab3.Text = dateTimePicker1.Value.ToString();
                Cart.instance.lab4.Text = dateTimePicker2.Value.ToString();
                Cart.instance.lab5.Text = guestnum.SelectedItem.ToString();
                Cart.instance.pic.Image = pent;
                form.Show();
            }
            else if (radiobtnPres.Checked && guestnum.SelectedItem != null)
            {
                Pres = Image.FromFile(@"C:\Users\angel\source\repos\Hotel-Project-380\Hotel Project 380\pics\the palms4.jpg");
                Cart.instance.lab1.Text = "Presidential Sky Villa";
                Cart.instance.lab2.Text = "Three Master Bedrooms\nPool Table/Private Pool";
                Cart.instance.lab3.Text = dateTimePicker1.Value.ToString();
                Cart.instance.lab4.Text = dateTimePicker2.Value.ToString();
                Cart.instance.lab5.Text = guestnum.SelectedItem.ToString();
                Cart.instance.pic.Image = Pres;
                form.Show();
            }
        }

        private void guestnum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
