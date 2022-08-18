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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\angel\OneDrive\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30");
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


        /// <summary>
        /// Make Reservation
        /// Angel Reyes
        /// 08/16/2022
        /// 
        /// The New Reservation form contains a "Book Now" module/class that will allow the user to book a New Reservation once the number of guest, CheckIn/CheckOut,
        /// and Room Type has been provided. User will not be able to move foward to the cart form unless all information is present. Once all data is provided
        /// a new cart form will display as a confirmation allowing the user to enter personal data and payment. Once all data is accquired the user just checks out
        /// and creates the new reservation.
        /// 
        /// Important funtctions I used in this class were conversion functions such as .Tostring() or toInt32(). These were mainly used because important input and output values
        /// such as CheckIn/Checkout, number of guest, total nights, total price, and images were all used to be manipulated accross forms (between new reservation and cart).
        /// 
        /// An important structure/algorithm I used was making instances to transfer data across forms to be allowed to use those input/outputs across forms.
        /// I selected this algorithm because this way I can use the inputs/outputs that are important between both forms. 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
              
              
                SqlCommand myCommand = new SqlCommand("SELECT COUNT(1) FROM RoomInfo_Table WHERE CheckIn IS NULL and CheckOut IS NULL ", Con);
                myCommand.Connection.Open();
                object obj = myCommand.ExecuteScalar();
                if (Convert.ToInt32(obj) > 0)
                {
                    form.Show();
                    //SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from RoomInfo_Table where RoomType = 'Studio' and CheckIn < '" + Checkout_calender.Value.ToString() + "' and CheckOut > '" + CheckIn_calender.Value.ToString() + "'", Con);
                    //DataTable dt = new DataTable();
                    //sda.Fill(dt);
                    //if (dt.Rows[0][0].ToString() == "1")
                    //{
                    //    MessageBox.Show("Room already reserved for the following dates.\nChoose new dates.");

                    //}
                    //else
                    //{
                    //    form.Show();

                    //}
                }
                else
                {
                    MessageBox.Show("Room selection are all booked.\nOur apologies. :(");
                }

               
                myCommand.Connection.Close();
               
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
                string Suite = "Suite";

                SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from RoomInfo_Table where RoomType = '" + Suite + "' and CheckIn < '" + Checkout_calender.Value.ToString() + "' and CheckOut > '" + CheckIn_calender.Value.ToString() + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Room already reserved for the following dates.\nChoose new dates.");

                }
                else
                {
                    form.Show();

                }


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
                string Pent = "PentHouse";

                SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from RoomInfo_Table where RoomType = '" + Pent + "' and CheckIn < '" + Checkout_calender.Value.ToString() + "' and CheckOut > '" + CheckIn_calender.Value.ToString() + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Room already reserved for the following dates.\nChoose new dates.");

                }
                else
                {
                    form.Show();

                }

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

                string Presidential = "Presidential";

                SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from RoomInfo_Table where RoomType = '" + Presidential + "' and CheckIn < '" + Checkout_calender.Value.ToString() + "' and CheckOut > '" + CheckIn_calender.Value.ToString() + "' ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Room already reserved for the following dates.\nChoose new dates.");

                }
                else
                {
                    form.Show();

                }
            }
        }

        private void guestnum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Amarinder Singh
        /// 8/9/16
        ///
        /// The commented out code below was coded to connected sql database to our data,
        /// also transfer transfer images from one form to another, later on we decieded we wanted to
        /// do it differently, so angel took over and coded a bit different than me dividing the code into to forms,
        /// the cart and the New reservation form.
        ///
        ///this code also calculated numeber of days stayed, where it was recycled by angel to make it better
        ///
        /// this also sent data from one form to another where i had to make an instance and transfer it
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*
         
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
        }*/


    }
}
