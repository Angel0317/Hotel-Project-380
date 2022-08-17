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

        //Change SQL connection to HotelDB.mdf

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student.IT-STULOAN-714.004\Downloads\Hotel.mdf;Integrated Security=True;Connect Timeout=30");
        /// <summary>
        /// Populate
        /// 08/08/2022
        /// Wesley Cox
        /// 
        /// Populate is a generic code that will be used to display data from a desired database table
        /// 
        /// Input will be from the Cart Table and output will be the Cart Table
        /// 
        /// The SQL Data Table
        /// 
        /// Algorithm just takes all the table data found and displays
        /// </summary>
        public void populate()
        {
            /*
             * This function will put the found reservation into the checkbox for user to select to cancel
             */

            Con.Open();
            string Myquery = "select * from Cart_Table";
            SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationDisplay.DataSource = ds.Tables[0];
            if(ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Banananas");
            }
            Con.Close();
        }
        /// <summary>
        /// Initializes the GUI Edit form
        /// </summary>
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

        /// <summary>
        /// Find Reservation
        /// Wesley
        /// 08/09/2022
        /// 
        /// This method will take the data entered in the GUI and cross search it in the matching database table for a matching
        /// reservation. If the data is not a match the program will inform the user that the reservation cannot be found, when 
        /// a reservation is found it will then display the reservation found on the display box on the right of the page.
        /// 
        /// The input is user input into the GUI and the already stored data in the data table, the output is the reservation
        /// found with all the data in the reservation and not just the information that is looked up
        /// 
        /// Data structures used are SQL data tables
        /// 
        /// The ALgorithm is quite simple, the code runs a check to see if all data entered matches and if its all matched to the 
        /// same reservation/data entry
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * Lookup Entered Reservation ID, First Name, Last name and check in date 
             * in data table for a matching reservation, if found the results will display
             * in checkbox form on the right
             */
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) from Cart_Table where ReservationID = '"+reservationidtb.Text+"' and FirstName = '"+firstnametb.Text+"' and LastName = '"+lastnametb.Text+"' ",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                // MessageBox.Show("Reservation Found!");

                /*
                 * if a reservation is found, the data from table will now be displayed on the checkbox 
                 * on the right of the form
                 */
                string Myquery = "select * from Cart_Table where ReservationID = '"+reservationidtb.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ReservationDisplay.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Cannot find reservation, please try again :)");
            }
            Con.Close();
            //and Checkin = '"+checkintb+"'
        }

        /// <summary>
        /// Delete Reservation
        /// Wesley Cox
        /// 08/13/2022
        /// 
        /// The delete method will enirely depend on if a reservation has been found, the delete method will use the unique identifier
        /// that finds the reservation to then find the same thing to remove it from the table. Once a reservation is deleted there is
        /// no bringing back that reservation unless an identical one is made.
        /// 
        /// Input values are the same values used for reservation lookup
        /// 
        /// Data table 
        /// 
        /// The algorithm used is one that takes certain input from a user and looks for an exact match in order to execute the
        /// deletion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * Selected reservation from CheckedListBox1 will be deleted from database
             * I.E. cancelling the reservation
             */
             Con.Open();
             String query = "delete from Cart_Table where ReservationID =" + reservationidtb.Text + "";
             SqlCommand cmd = new SqlCommand(query, Con);
             cmd.ExecuteNonQuery();
             MessageBox.Show("Reservation Deleted");
             Con.Close();
            

           
        }

        private void ReservationDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * Searched reservation will be displayed here from the guestinfopage
             */
        }
    }
}
