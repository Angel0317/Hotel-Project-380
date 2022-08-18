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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student.IT-STULOAN-714.004\Downloads\Hotel.mdf;Integrated Security=True;Connect Timeout=30");
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

        private void Staff_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Guest Reservation Lookup
        /// Wesley Cox
        /// 08/16/2022
        /// 
        /// This method will display all the guest reservations that have been made into the hotel database
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reservationtb_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "select * from Cart_Table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var staff = new DataSet();
            da.Fill(staff);
            AdminDisplaytb.DataSource = staff.Tables[0];
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminDisplaytb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Admin Reservation Deletion
        /// Wesley Cox
        /// 8/17/2022
        /// 
        /// This method is responsible for deleting the reservation with the same email, first name and last name that the
        /// admin inputs after looking through all reservations
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click_1(object sender, EventArgs e)
        {

            Con.Open();
            String query = "delete from Cart_Table where Email =" + numbertb.Text + " and FirstName = '" +firstnametb.Text+ "' and LastName = '" +lastnametb.Text+ "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Deleted");
            Con.Close();


        }
    }
}
