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

namespace ConnectedCrud
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        public int StudentID;
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("insert into Students values (@name, @FatherName, @Roll, @Address, @Mobile)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text); 
                cmd.Parameters.AddWithValue("@Roll", txtRollNo.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Student is successfully saved in db", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentsRecord();
                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if(txtStudentName.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("update Students set Name = @name, FatherName = @FatherName, RollNumber = @Roll, Address = @Address, Mobile = @Mobile where StudentID=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@Roll", txtRollNo.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student info Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentsRecord();
                ResetFormControls();
            }
            else
            {

                MessageBox.Show("Please Select a student to update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        private void GetStudentsRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Students", con);
            DataTable dt=new DataTable();

            con.Open(); 
            SqlDataReader dr=cmd.ExecuteReader();
            dt.Load(dr);    
            con.Close();    

            dg.DataSource = dt; 

        }

        private void ResetFormControls()
        {
            StudentID = 0;  
            txtStudentName.Clear();
            txtFatherName.Clear();
            txtRollNo.Clear();
            txtMobile.Clear();
            txtAddress.Clear();
            txtStudentName.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetFormControls();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //whenever particualr row is selected it has to be displayed in the above text boxes
            StudentID = Convert.ToInt32(dg.SelectedRows[0].Cells[0].Value);
            txtStudentName.Text = dg.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = dg.SelectedRows[0].Cells[2].Value.ToString();
            txtRollNo.Text = dg.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = dg.SelectedRows[0].Cells[4].Value.ToString();
            txtMobile.Text = dg.SelectedRows[0].Cells[5].Value.ToString();
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(StudentID >0)
            {
                SqlCommand cmd = new SqlCommand("delete from Students where StudentID=@ID", con);
                cmd.CommandType = CommandType.Text;
   
                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Student deleted successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudentsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please Select a student to delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
