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
                studio = Image.FromFile(@"C:\Users\angel\source\repos\Hotel-Project-380\Hotel Project 380\pics\studio5.jpg");
                Cart.instance.lab1.Text = "Studio Deluxe Stay";
                Cart.instance.lab2.Text = "One King or Two Queen";
                Cart.instance.lab3.Text = CheckIn_calender.Value.ToString();
                Cart.instance.lab4.Text = Checkout_calender.Value.ToString();
                Cart.instance.lab5.Text = guestnum.SelectedItem.ToString();
                Cart.instance.pic.Image = studio;

                DateTime d1 = CheckIn_calender.Value;
                DateTime d2 = Checkout_calender.Value;
                TimeSpan time = d2 - d1;
                double Days = time.TotalDays;
                int days = Convert.ToInt32(Days);
                Cart.instance.lab6.Text = days.ToString();
                int total_price = days * 500;
                Cart.instance.lab7.Text = total_price.ToString();

                form.Show();
               
            }
            else if(radioBtnSuite.Checked && guestnum.SelectedItem != null)
            {
                suite = Image.FromFile(@"C:\Users\angel\source\repos\Hotel-Project-380\Hotel Project 380\pics\suitepic2.jpg");
                Cart.instance.lab1.Text = "Panoramic Suite Stay";
                Cart.instance.lab2.Text = "One Bedroom\nOne King or Two Queen";
                Cart.instance.lab3.Text = CheckIn_calender.Value.ToString();
                Cart.instance.lab4.Text = Checkout_calender.Value.ToString();
                Cart.instance.lab5.Text = guestnum.SelectedItem.ToString();
                Cart.instance.pic.Image = suite;

                DateTime d1 = CheckIn_calender.Value;
                DateTime d2 = Checkout_calender.Value;
                TimeSpan time = d2 - d1;
                double Days = time.TotalDays;
                int days = Convert.ToInt32(Days);
                Cart.instance.lab6.Text = days.ToString();
                int total_price = days * 1000;
                Cart.instance.lab7.Text = total_price.ToString();
                form.Show();
                
               
            }
            else if(radioBtnPentHouse.Checked && guestnum.SelectedItem != null)
            {
                pent = Image.FromFile(@"C:\Users\angel\source\repos\Hotel-Project-380\Hotel Project 380\pics\pent.jpg");
                Cart.instance.lab1.Text = "Penthouse Sky View Stay";
                Cart.instance.lab2.Text = "Two King Beds\nTwo Master Bedrooms";
                Cart.instance.lab3.Text = CheckIn_calender.Value.ToString();
                Cart.instance.lab4.Text = Checkout_calender.Value.ToString();
                Cart.instance.lab5.Text = guestnum.SelectedItem.ToString();
                Cart.instance.pic.Image = pent;

                DateTime d1 = CheckIn_calender.Value;
                DateTime d2 = Checkout_calender.Value;
                TimeSpan time = d2 - d1;
                double Days = time.TotalDays;
                int days = Convert.ToInt32(Days);
                Cart.instance.lab6.Text = days.ToString();
                int total_price = days * 2000;
                Cart.instance.lab7.Text = total_price.ToString();


                form.Show();
            }
            else if (radiobtnPres.Checked && guestnum.SelectedItem != null)
            {
                Pres = Image.FromFile(@"C:\Users\angel\source\repos\Hotel-Project-380\Hotel Project 380\pics\the palms4.jpg");
                Cart.instance.lab1.Text = "Presidential Sky Villa";
                Cart.instance.lab2.Text = "Three Master Bedrooms\nPool Table/Private Pool";
                Cart.instance.lab3.Text = CheckIn_calender.Value.ToString();
                Cart.instance.lab4.Text = Checkout_calender.Value.ToString();
                Cart.instance.lab5.Text = guestnum.SelectedItem.ToString();
                Cart.instance.pic.Image = Pres;


                DateTime d1 = CheckIn_calender.Value;
                DateTime d2 = Checkout_calender.Value;
                TimeSpan time = d2 - d1;
                double Days = time.TotalDays;
                int days = Convert.ToInt32(Days);
                Cart.instance.lab6.Text = days.ToString();
                int total_price = days * 5000;
                Cart.instance.lab7.Text = total_price.ToString();

                form.Show();
            }
        }

        private void guestnum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
