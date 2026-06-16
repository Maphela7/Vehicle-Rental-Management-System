using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Information_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            prepareForm(this);
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            txtPassword.UseSystemPasswordChar = true;

        }

        private void prepareForm(Form form)
        {
            form.WindowState = FormWindowState.Maximized;
            form.ControlBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Width = this.ClientSize.Width * 2 / 5;
            panelRight.Dock = DockStyle.Right;
            panelRight.Width = this.ClientSize.Width * 3 / 5;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

         

        private void applyPaceholder(String placeholder, TextBox tb, bool isPassword)
        {
            if (isPassword)
            {
                 
            }
            else
            {
                 
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isAdmin = checkBox2.Checked;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (isAdmin)
                {

                    MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Proceed to the admin dashboard or main application window
                    this.Close();
                    new AdminDashboard().Show();
                }
                else
                {
                    MessageBox.Show("User login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Proceed to the user dashboard or main application window
                    
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            new Registercs().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
