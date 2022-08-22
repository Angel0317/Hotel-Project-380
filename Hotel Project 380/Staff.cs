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
        //Add connection String to local Database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\angel\OneDrive\Documents\Hotel.mdf;Integrated Security=True;Connect Timeout=30");
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
             this.Close();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }


        //}
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
        public System.Windows.Forms.DataGridViewAutoSizeColumnMode AutoSizeMode
        {
            get; set;
        }
        private void AdminDisplaytb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn column = AdminDisplaytb.Columns[2];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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

            SqlCommand myCommand = new SqlCommand("SELECT COUNT(*) FROM Cart_Table WHERE RoomNumber = '"+Adminroomtb.Text+"' and FirstName = '"+firstnametb.Text+"' and LastName = '"+lastnametb.Text+"'", Con);
            myCommand.Connection.Open();
            object obj = myCommand.ExecuteScalar();
            if (Convert.ToInt32(obj) > 0)
            {
                String query = "delete from Cart_Table where RoomNumber ='" + Adminroomtb.Text + "' and FirstName = '" + firstnametb.Text + "' and LastName = '" + lastnametb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                
                string update_room = "UPDATE RoomInfo_Table SET CheckIn = NULL, CheckOut = NULL WHERE RoomNumber = '" + Adminroomtb.Text + "'";
                SqlCommand reset_room = new SqlCommand(update_room, Con);
                reset_room.ExecuteNonQuery();
    
                MessageBox.Show("Mr./Ms." +lastnametb.Text+ " has been checked out.");
            }
            else
            {
                MessageBox.Show("No reservation was found to check out.");
            }

           myCommand.Connection.Close();
        }

        /// <summary>
        /// Display Rooms
        /// Wesley Cox
        /// 8/18/2022
        /// 
        /// This method will display the active rooms for the hotel admin to view. This will allow the admin to 
        /// edit the rooms and make them available for guest's after another 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {

            Con.Open();
            string query = "Select * from RoomInfo_Table";
            SqlDataAdapter da = new SqlDataAdapter(query,Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            AdminDisplaytb.DataSource = dt;
            Con.Close();
           
        }
    }
}
