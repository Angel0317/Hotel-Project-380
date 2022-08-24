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
using System.Net.Mail;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

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
        public Label lab6;
        public Label lab7; 
        public Label lab8;
        public PictureBox pic;
        public string typeofroom = "";
        
        public Cart()
        {
            InitializeComponent();
            instance = this;
            lab1 = roomKind;
            lab2 = roomDetails;
            lab3 = startdate;
            lab4 = leavedate;
            lab5 = totalGuest;
            lab6 = totalNights;
            lab7 = Totalprice;
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
        /// <summary>
        /// Cart Form
        /// Angel Reyes
        /// 08/16/2022
        /// The cart form contains a checkout_Click class/module will get all user's information and store it into a SQL table. If any textbox is left empty then user cannot checkout.
        /// Important input values in this module are firstname,lastname, phone number, email, zipcode, state, checkin/checkout dates, total guests, and total nights.
        /// The structure used in this class is a SQL table we chose this algorithm to store information and access it when needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
                sendMailToCustomer(lastName.Text, emailtxt.Text);
                string num = " ";
                cart.Open();
                SqlCommand room_num = new SqlCommand(" SELECT TOP 1 * FROM RoomInfo_Table WHERE RoomType = '" + typeofroom.ToString() + "' and CheckIn IS NULL and CheckOut IS NULL", cart);
                SqlDataReader reader1;
                reader1 = room_num.ExecuteReader();
                if (reader1.Read())
                {
                    num = reader1.GetValue(3).ToString();

                }
                cart.Close();

                cart.Open();
                SqlCommand cmd = new SqlCommand("insert into Cart_Table values ('" + firstName.Text + "', '" + lastName.Text + "', '" + addresstxt.Text + "', " +
                    "'" + phonetxt.Text + "', '" + emailtxt.Text + "',  '" + zipcodetxt.Text + "', '" + statetxt.Text + "', " +
                    "'" + startdate.Text + "', '" + leavedate.Text + "', '" + totalGuest.Text + "', '" + totalNights.Text + "', '" + num.ToString() + "')", cart);
                cmd.ExecuteNonQuery();
                cart.Close();

                cart.Open();
                SqlCommand room_assign = new SqlCommand("UPDATE RoomInfo_Table SET CheckIn = '" + startdate.Text + "', CheckOut = '" + leavedate.Text + "' WHERE RoomNumber = '" + num + "'", cart);
                room_assign.ExecuteNonQuery();
                cart.Close();
                this.Close();
                MessageBox.Show("Reservation Confirmed! :D");
  
            } 
        }
        ///<summary>
        ///Sending Email
        ///Ted Wu
        ///8/15/2022-present
        ///
        /// The Sending Email function will send out the email with confirmation ID and all the reservation detail that's restored in the sql table.
        ///
        /// The current code is unfinished due to google close the access to the less secure app which need to connect with SMTP server with applicatoin code
        /// But it also give out an error says SMTP server needs secure connection, currently looking into and try out some solution.
        ///
        /// Input value will be used as the user type in the cart, output will be the email that's sent out.
        ///
        /// Datat structure is used from the sql table
        ///
        /// </summary>
        protected void sendMailToCustomer(String name, string email)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("BlissHotel01@gmail.com");
            msg.To.Add(email);
            msg.Subject = "Bliss Hotel Reservation Email";
            msg.Body = "<h2>Bliss Hotel: Congration! your reservation has been confirmed.</h2>" + "<h3> \n Dear Mr./Ms.</h3>" + name + "<h3>, thank you for staying with us. </h3>";
            msg.IsBodyHtml = true;
            msg.ReplyToList.Add(new MailAddress(email, name));

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25))
            {

                smtp.Credentials = new NetworkCredential("BlissHotel01@gmail.com", " kkvjnveupeyffqll");
                smtp.EnableSsl = true;
                smtp.Send(msg);
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Totalprice_Click(object sender, EventArgs e)
        {

        }

        private void billingtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomDetails_Click(object sender, EventArgs e)
        {

        }

        private void leavedate_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Summary_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void totalGuest_Click(object sender, EventArgs e)
        {

        }
    }
}
