using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace studiosoftware
{
    public partial class Employee_Management : Form
    {
        SqlConnection conn = new SqlConnection ("Data Source=LAPTOP-NONUB9GO\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
        public Employee_Management()
        {
            InitializeComponent();
        }

        private SqlConnection getConnection()
        {
            string connectionString;
            SqlConnection conn;
            connectionString = "Data Source=LAPTOP-NONUB9GO\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            return conn;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
            
        }

        private void firstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstName.Text) == true)
            {
                firstName.Focus();
                firstNameErrorProvider.SetError(this.firstName, "Required!");
            }

            else
            {
                firstNameErrorProvider.Clear();
            }
        }

        

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastName.Text) == true)
            {
                lastName.Focus();
                lastNameErrorProvider.SetError(this.lastName, "Required!");
            }

            else
            {
                lastNameErrorProvider.Clear();
            }
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(email.Text, pattern))
            {
                emailErrorProvider.Clear();
            }
            else
            {
                emailErrorProvider.SetError(this.email, "Invalid email!");
                return;
            }
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(address.Text) == true)
            {
                address.Focus();
               addressErrorProvider.SetError(this.address, "Required!");
            }

            else
            {
                addressErrorProvider.Clear();
            }
        }

        private void mobileNumber_Leave(object sender, EventArgs e)
        {
           
                if (string.IsNullOrEmpty(mobileNumber.Text) == true)
            {
                mobileNumber.Focus();
                mobileNumErrorProvider.SetError(this.mobileNumber, "Required!");
            }

            else
            {
                mobileNumErrorProvider.Clear();
            }
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value ="F";
            else
                value = "M";
           
            String sql = "Insert into Employee_info (fName, lName, email, address, DOB, Gender, joinedDate, mobileNum ) values ('" + firstName.Text + "','" + lastName.Text + "', '" + email.Text + "','" + address.Text + "' , '" + dobDatepicker.Value + "','" + value + "','" + joinedDatepicker.Value + "','" + mobileNumber.Text + "')";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection= getConnection();
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            MessageBox.Show("Record inserted successfully!");
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
           this.Hide();
           ViewEmployee viewEmployee = new ViewEmployee();
           viewEmployee.Show();
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

           /* string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = "F";
            else
                value = "M";

            try
            {
                if (firstName.Text == "")
                {
                    MessageBox.Show("Enter Employee Name To Update");
                }
                else
                {
                    SqlCommand cmdupdate = new SqlCommand("Update EmployeeDetails SET fName='" + firstName.Text + "', lName='" + lastName.Text + "' ,email='" + email.Text + "', address='" + address.Text + "' , DOB='" + dobDatepicker.Value + "' , gender='" + value + "', joinedDate='" + joinedDatepicker.Value + "', mobileNum='" + mobileNumber.Text + "', where fName=" + firstName.Text + "", conn);
                    conn.Open();
                    cmdupdate.CommandType = CommandType.Text;
                    cmdupdate.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }*/

          
        }
    }

    }

