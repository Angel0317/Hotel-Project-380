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



            /*          try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("BlissHotel01@gmail.com");
                    mail.To.Add("emailtxt.Text");
                    mail.Subject = "Test Sending Mail";
                    mail.Body = "<h1> This is Body</h1>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smpt.gamil.com", 587))
                    {
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf RemoteCertificateValidationCallback)
                        NetworkCredential networkCredential = new System.Net.NetworkCredential("BlissHotel01@gmail.com", "oroyphioaozaxkta");
                        smtp.Credentials = networkCredential;
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Send(mail);

                        label1.Text = "Mail Sent";
                    }
                   Public Shared Function RemoteCertificateValidationCallback(ByVal sender As Object, ByVal certificate As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As Net.Security.SslPolicyErrors) As Boolean
        
                   Return True
    
                   End Function
                }
            }

            catch (Exception ex)
            {
                label1.Text = ex.Message;

            }
            */
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
