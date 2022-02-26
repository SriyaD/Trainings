using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedStoredProcedure
{
    public partial class Form1 : Form
    {
        public int EmpID;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();

        }

        private void button2_Click(object sender, EventArgs e)
        {  
            int EmpId = int.Parse(txtId.Text);
            String EmpName = txtName.Text;
            int EmpAge = int.Parse(txtAge.Text);
            String sex="";
            if(radioMale.Checked == true)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            } 
            String EmpMobile = txtMobile.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("exec InsertEmp_SP '" + EmpId + "', '" + EmpName + "','" + EmpAge + "', '" + sex + "',  '" + EmpMobile + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Inserted");
            display();
            ClearAll();
        }
        void display()
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("exec DisplayEmp_SP", con);
            //SqlDataAdapter sa = new SqlDataAdapter(cmd);

            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("DisplayEmp_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            con.Close();
            DataTable dt = new DataTable();
            sa.Fill(dt);
           
            dg.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearAll();
            
        }
        private void ClearAll()
        {
            txtName.Clear();
            txtId.Clear();
            txtAge.Clear();
            if (radioFemale.Checked == true)
            {
                radioFemale.Checked = false;
            }
            if (radioMale.Checked == true)
            {
                radioMale.Checked = false;
            }
            txtMobile.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if(EmpID > 0)
            //{
                int EmpId = int.Parse(txtId.Text);
                String EmpName = txtName.Text;
                int EmpAge = int.Parse(txtAge.Text);
                String sex = "";
                if (radioMale.Checked == true)
                {
                    sex = "Male";
                }
                else
                {
                    sex = "Female";
                }
                String EmpMobile = txtMobile.Text;
            //con.Open();
            //SqlCommand cmd = new SqlCommand("exec UpdateEmp_SP '" + EmpId + "', '" + EmpName + "','" + EmpAge + "', '" + sex + "',  '" + EmpMobile + "' ", con);
            //cmd.ExecuteNonQuery();
            //con.Close();

            //MessageBox.Show("Successfully Updated");
            //display();
            //ClearAll();
            //}
            //else
            //{
            //    MessageBox.Show("Please Select a Employee to update", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}



            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("UpdateEmp_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", EmpId);
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.Parameters.AddWithValue("@EmpAge", EmpAge);
            cmd.Parameters.AddWithValue("@EmpGender", EmpId);
            cmd.Parameters.AddWithValue("@EmpMobile", EmpMobile);
            //con.Open();
            int num = cmd.ExecuteNonQuery();
            if (num > 0)
            {
                display();
                MessageBox.Show("Updated Inserted");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
            con.Close();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void dg_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //whenever particualr row is selected it has to be displayed in the above text boxes
            //EmpID = Convert.ToInt32(dg.SelectedRows[0].Cells[0].Value);
            //txtId.Text = dg.SelectedRows[0].Cells[0].Value.ToString();
            //txtName.Text = dg.SelectedRows[0].Cells[1].Value.ToString();
            //txtAge.Text = dg.SelectedRows[0].Cells[1].Value.ToString();
            //radioFemale.Text = dg.SelectedRows[0].Cells[3].Value.ToString();
            //radioMale.Text = dg.SelectedRows[0].Cells[3].Value.ToString();
            //txtMobile.Text = dg.SelectedRows[0].Cells[4].Value.ToString();

        }



        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //int EmpId = int.Parse(txtId.Text);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("exec DeleteEmpl_SP '" + EmpId + "'", con);
            //cmd.ExecuteNonQuery();
            //con.Close();

            //MessageBox.Show("Successfully Deleted");
            //display();
            //ClearAll();


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            int EmpId = int.Parse(txtId.Text);
            SqlCommand cmd = new SqlCommand("DeleteEmpl_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", EmpId);
            int num = cmd.ExecuteNonQuery();
            if (num > 0)
            {
                display();
                MessageBox.Show("Deleted");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
            con.Close();
        }

        private void btn_Insert(object sender, EventArgs e)
        {
            int EmpId = int.Parse(txtId.Text);
            String EmpName = txtName.Text;
            int EmpAge = int.Parse(txtAge.Text);
            String sex = "";
            if (radioMale.Checked == true)
            {
                sex = "Male";
            }
            else
            {
                sex = "Female";
            }
            String EmpMobile = txtMobile.Text;

            //con.Open();
            //SqlCommand cmd = new SqlCommand("exec InsertEmp_SP '" + EmpId + "', '" + EmpName + "','" + EmpAge + "', '" + sex + "',  '" + EmpMobile + "' ", con);
            //cmd.ExecuteNonQuery();
            //con.Close();

            //MessageBox.Show("Successfully Inserted");
            //display();
            //ClearAll();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("InsertEmp_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", EmpId);
            cmd.Parameters.AddWithValue("@EmpName", EmpName);
            cmd.Parameters.AddWithValue("@EmpAge", EmpAge);
            cmd.Parameters.AddWithValue("@EmpGender", EmpId);
            cmd.Parameters.AddWithValue("@EmpMobile", EmpMobile);
            con.Open();
            int num=cmd.ExecuteNonQuery();
            if(num > 0)
            {
                display();
                MessageBox.Show("Successfully Inserted");
                ClearAll();
            }
            else
            {
                MessageBox.Show("NotInserted");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.Open();
            string query = string.Format("select EmpId, EmpName from Employee where EmpId = {0}", txtId.Text);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);    
            sa.Fill(dt);    
            dg.DataSource = dt;
            con.Close();
        }
    }
}
