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
    public partial class AdminDashboard : Form
    {
        
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            this.KeyPreview = true;
            this.KeyDown += AdminDashboard_KeyDown;
        }

        private void AdminDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddVehicle addVehicle = new AddVehicle("Add");
            addVehicle.Location = new Point(this.Width/3, this.Height/3);
            addVehicle.ShowDialog();

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
