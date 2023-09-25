using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace Student_Info
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        MySqlConnection myconn;
        string mycon = "Server = localhost; Database = studentDB; Uid = root; Pwd =;";
        MySqlCommand mycmd;
        MySqlDataReader rdr;

        private void frmStudent_Load(object sender, EventArgs e)
        {
            myconn = new MySqlConnection(mycon);
            myconn.Open();
            MessageBox.Show("Connected to MySQL Server", "Connection Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadStudents(listView1);
            getLastNumber();
            falseDefault();

            //Course
            loadCourse(cbCourse);

            cbYear.Items.Add("1ST");
            cbYear.Items.Add("2ND");
            cbYear.Items.Add("3RD");
            cbYear.Items.Add("4TH");

        }
        /**private void txtLname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLname.Text){
                falseDefault();
            }
            else
            {
                btnNew.Enabled = true;

            }
        }*/
        private void btnNew_Click(object sender, EventArgs e)
        {
            trueDefault();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string lname = txtLname.Text;
            string fname = txtFname.Text;
            string mname = txtMname.Text;
            string address = txtAddress.Text;

            string course = cbCourse.SelectedItem.ToString();
            string year = cbYear.SelectedItem != null ? cbYear.SelectedItem.ToString() : null;

            string sql = "INSERT INTO tbl_students (last_name, first_name, middle_name, address, course, s_year) VALUES " +
                    "('" + lname + "','" + fname + "','" + mname + "','" + address + "','" + course + "','" + year + "')";

            myconn = new MySqlConnection(mycon);
            myconn.Open();
            mycmd = new MySqlCommand(sql, myconn);
            mycmd.ExecuteNonQuery();

            loadStudents(listView1);

        }
        private void loadCourse(ComboBox cbCourse)
        {
            cbCourse.Items.Clear();
            string sql = "SELECT * FROM tbl_year";
            myconn = new MySqlConnection(mycon);
            myconn.Open();
            mycmd = new MySqlCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            rdr = mycmd.ExecuteReader();
            while (rdr.Read())
            {
                cbCourse.Items.Add(rdr[1].ToString());
            }
            myconn.Close();
            myconn.Dispose();

        }
        private void loadStudents(ListView listView)
        {
            string sql = "SELECT * FROM tbl_students ORDER by id";
            myconn = new MySqlConnection(mycon);
            myconn.Open();
            mycmd = new MySqlCommand(sql, myconn);
            rdr = mycmd.ExecuteReader();
            listView.Items.Clear();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    listView.Items.Add(rdr.GetString(0));
                    listView.Items[listView.Items.Count - 1].SubItems.Add(rdr[1].ToString());
                    listView.Items[listView.Items.Count - 1].SubItems.Add(rdr[2].ToString());
                    listView.Items[listView.Items.Count - 1].SubItems.Add(rdr[3].ToString());
                    listView.Items[listView.Items.Count - 1].SubItems.Add(rdr[4].ToString());
                    listView.Items[listView.Items.Count - 1].SubItems.Add(rdr[5].ToString());
                    listView.Items[listView.Items.Count - 1].SubItems.Add(rdr[6].ToString());
                }
            }

        }
        private int getLastNumber()
        {
            int sID = 0;
            string sql = "SELECT * FROM tbl_students ORDER BY id DESC";
            myconn = new MySqlConnection(mycon);
            myconn.Open();
            mycmd = new MySqlCommand(sql, myconn);
            rdr = mycmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    sID = int.Parse(rdr[0].ToString());
                    break;
                }
            }
            myconn.Close();
            myconn.Dispose();
            return sID;
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            // Update the fields with the selected item's data
            txtID.Text = selectedItem.SubItems[0].Text;
            txtLname.Text = selectedItem.SubItems[1].Text;
            txtFname.Text = selectedItem.SubItems[2].Text;
            txtMname.Text = selectedItem.SubItems[3].Text;
            txtAddress.Text = selectedItem.SubItems[4].Text;
            cbCourse.Text = selectedItem.SubItems[5].Text;
            cbYear.Text = selectedItem.SubItems[6].Text;

            // Disable edit and delete buttons
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnUpdate.Enabled = true;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string lname = txtLname.Text;
            string fname = txtFname.Text;
            string mname = txtMname.Text;
            string address = txtAddress.Text;
            string course = cbCourse.SelectedItem.ToString();
            string year = cbYear.SelectedItem.ToString();

            string sql = "UPDATE tbl_students SET last_name= '" + lname + "', first_name = '" + fname + "' , middle_name = '" + mname + "'" +
                " , address = '" + address + "' , course = '" + course + "' , s_year = '" + year + "' WHERE id = " + id;

            myconn = new MySqlConnection(mycon);
            myconn.Open();
            mycmd = new MySqlCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            myconn.Close();
            myconn.Dispose();

            loadStudents(listView1);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rslt = MessageBox.Show("Do you really want to delete this data?", "DELETE", MessageBoxButtons.YesNo);
                if (rslt == DialogResult.Yes)
                {
                    string sql = "DELETE FROM tbl_students WHERE id = '" + txtID.Text + "'";
                    myconn = new MySqlConnection(mycon);
                    myconn.Open();
                    mycmd = new MySqlCommand(sql, myconn);
                    mycmd.ExecuteNonQuery();
                    myconn.Close();

                    MessageBox.Show("Record Deleted!");
                    loadStudents(listView1);
                    falseDefault();

                }
            }
            catch
            {
                btnDelete.Enabled = true;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult rslt = MessageBox.Show("Do you really want to cancel this operation?", "CANCEL", MessageBoxButtons.YesNo);
            if (rslt == DialogResult.Yes)
            {
                falseDefault();
            }
        }

        private void falseDefault()
        {
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            txtAddress.Enabled = false;
            txtFname.Enabled = false;
            txtFname.Text = null;
            txtAddress.Text = null;
            txtLname.Text = null;
            txtAddress.Text = null;
            txtMname.Text = null;
            txtID.Text = null;
            txtID.Enabled = false;
            txtLname.Enabled = false;
            txtMname.Enabled = false;
            cbCourse.Enabled = false;
            cbYear.Enabled = false;
            cbCourse.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
            listView1.Enabled = false;
        }
        private void trueDefault()
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;
            txtAddress.Enabled = true;
            txtFname.Enabled = true;
            txtID.Enabled = true;
            txtLname.Enabled = true;
            txtMname.Enabled = true;
            cbCourse.Enabled = true;
            cbYear.Enabled = true;
            listView1.Enabled = true;
        }


    }
}