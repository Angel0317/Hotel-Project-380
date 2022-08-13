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
    public partial class Edit : Form
    {
        /*
         * Connect Sql Server data for all relevant reservation information
         */

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student.IT-STULOAN-714.004\Documents\GitHub\Hotel-Project-380\HotelDB.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            /*
             * This function will put the found reservation into the checkbox for user to select to cancel
             */

            Con.Open();
            string Myquery = "select * from GuestInfo_Table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            reservationCheckBoxEdit.DataSource = ds.Tables[0];
            if(ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Banananas");
            }
            Con.Close();
        }
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*
             * Selected Checkin Date for reservation
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * Lookup Entered Reservation ID, First Name, Last name and check in date 
             * in data table for a matching reservation, if found the results will display
             * in checkbox form on the right
             */
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from GuestInfo_Table where ReservationId = '"+reservationidtb.Text+"' " +
                "and firstName = '"+firstnametb.Text+"' and lastName = '"+lastnametb.Text+"' ",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Reservation Found!");

                /*
                 * if a reservation is found, the data from table will now be displayed on the checkbox 
                 * on the right of the form
                 */
                string Myquery = "select * from GuestInfo_Table";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                reservationCheckBoxEdit.DataSource = ds.Tables[0];
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Table found, Sending data to checkbox");
                }
            }
            else
            {
                MessageBox.Show("Cannot find reservation, please try again :)");
            }
            Con.Close();
            //and Checkin = '"+checkintb+"'
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*
             * Last Name on Reservation
             */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * Selected reservation from CheckedListBox1 will be deleted from database
             * I.E. cancelling the reservation
             */
            Con.Open();
            String query = "delete from GuestInfo_Table where ReservationId =" + reservationidtb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con); 
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation Deleted");
            Con.Close();
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * All reservations that have been found with matching resID, name and checkin 
             * will appear here for guest to select
             */
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
             * Reservation ID from confirmation
             */
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*
             * First name on reservation
             */
        }
    }
}
