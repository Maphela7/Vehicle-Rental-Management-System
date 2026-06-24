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
    public partial class ClientDashboard : Form
    {
        public ClientDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
            this.KeyPreview = true;

           
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            lblAvailVehicles.Location = new Point((this.Width / 2) - lblAvailVehicles.Width / 2, lblAvailVehicles.Width / 3);
        }

        private void ClientDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAvailVehicles_Click(object sender, EventArgs e)
        {

        }
    }
}
